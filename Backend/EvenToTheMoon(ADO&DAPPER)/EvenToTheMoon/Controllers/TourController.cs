using BLL.DTO.Responses;
using EvenToTheMoon.BLL.Interfaces.Services;
using EvenToTheMoon.DAL.Entities;
using EvenToTheMoon.DAL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EvenToTheMoon.Controllers
{
    
    public class TourController : ControllerBase
    {
        private readonly ILogger<TourController> _logger;

        private IUnitOfWork _unitofWork;
        private IToursService _tourService;

        public TourController(ILogger<TourController> logger, IUnitOfWork unitofWork, IToursService tourService)
        {
            _logger = logger;
            _unitofWork = unitofWork;
            _tourService = tourService;
        }

        [HttpGet("GetTourById")]
        public async Task<ActionResult<ToursResponse>> GetByIdAsync(int id)
        {
            try
            {
                var results = await _tourService.SPGetByIdTour(id);
                _unitofWork.Commit();
                _logger.LogInformation($"Returned tour id ${id} from database.");
                return Ok(results);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Transaction Failed! Something went wrong inside SPGetByIdTour() action: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }
    }
}
