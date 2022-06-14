using EvenToTheMoon.BLL.Interfaces.Services;
using EvenToTheMoon.DAL.Entities;
using EvenToTheMoon.DAL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EvenToTheMoon.Controllers
{
    
    public class CountryController : ControllerBase
    {
        private readonly ILogger<CountryController> _logger;

        private IUnitOfWork _unitofWork;
        private ICountryService _countryService;

        public CountryController(ILogger<CountryController> logger, IUnitOfWork unitofWork, ICountryService countryService)
        {
            _logger = logger;
            _unitofWork = unitofWork;
            _countryService = countryService;
        }

        [HttpGet("GetAllCountries")]

        public async Task<ActionResult<IEnumerable<Country>>> GetAllCountriesAsync()
        {
            try
            {
                var results = await _countryService.GetAsync();
                _unitofWork.Commit();
                _logger.LogInformation($"Returned countries from database.");
                return Ok(results);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Transaction Failed! Something went wrong inside GetAsync() action: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }
    }
}
