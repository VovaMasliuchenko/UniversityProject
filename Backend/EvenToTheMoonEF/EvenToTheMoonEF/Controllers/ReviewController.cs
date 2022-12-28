using EvenToTheMoon_EF_.BLL.DTO.Requests;
using EvenToTheMoon_EF_.BLL.Interfaces.Services;
using EvenToTheMoon_EF_.DTO.Responses;
using EvenToTheMoonEF.BLL.Validation;
using EvenToTheMoonEF.DAL.Context;
using EvenToTheMoonEF.DAL.Entities;
using EvenToTheMoonEF.DAL.Entities.Models;
using EvenToTheMoonEF.DAL.Interfaces;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EvenToTheMoonEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : Controller
    {
        private readonly ILogger<ReviewController> _logger;

        private IUnitOfWork _unitofWork;
        private IReviewService _reviewService;
        EvenToTheMoonDBContext _db;

        public ReviewController(ILogger<ReviewController> logger, IUnitOfWork unitofWork, IReviewService reviewService, EvenToTheMoonDBContext db)
        {
            _logger = logger;
            _unitofWork = unitofWork;
            _reviewService = reviewService;
            _db = db;
        }

        /*[HttpGet("GetAllReview")]
        public async Task<ActionResult<ReviewResponse>> GetAllReview()
        {
            return Ok(await _reviewService.GetAll());
        }*/

        [AllowAnonymous]
        [HttpGet("GetReview")]
        public async Task<ActionResult<ReviewResponse>> GetReview([FromQuery] ReviewParameters reviewParameters)
        {
            return Ok(await _reviewService.GetAllPaged(reviewParameters));
        }

        [AllowAnonymous]
        [HttpGet("GetReviewById")]
        public async Task<ActionResult<ReviewResponse>> GetReviewById(int id)
        {
            return Ok(await _reviewService.GetByIdAsync(id));
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] ReviewRequest request)
        {
            ReviewValidator validator = new ReviewValidator();
            List<string> ValidationMessages = new List<string>();
            var validationResult = validator.Validate(request);
            var response = new ResponseModel();
            if (!validationResult.IsValid)
            {
                foreach (ValidationFailure failure in validationResult.Errors)
                {
                    ValidationMessages.Add(failure.ErrorMessage);
                }
                response.ValidationMessages = ValidationMessages;
                return Ok(response);
            }
            await _reviewService.InsertAsync(request);
            return Ok();
        }
    }
}
