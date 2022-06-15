using EvenToTheMoon_EF_.BLL.Interfaces.Services;
using EvenToTheMoon_EF_.DTO.Responses;
using EvenToTheMoonEF.DAL.Context;
using EvenToTheMoonEF.DAL.Entities;
using EvenToTheMoonEF.DAL.Entities.Models;
using EvenToTheMoonEF.DAL.Interfaces;
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

        [HttpGet("GetAllReview")]
        public async Task<ActionResult<ReviewResponse>> GetAllReview()
        {
            return Ok(await _reviewService.GetAll());
        }

        [HttpGet("GetReview")]
        public async Task<ActionResult<ReviewResponse>> GetReview([FromQuery] ReviewParameters reviewParameters)
        {
            return Ok(await _reviewService.GetAllPaged(reviewParameters));
        }
    }
}
