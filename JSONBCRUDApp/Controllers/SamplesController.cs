using JSONBCRUDApp.Data;
using JSONBCRUDApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JSONBCRUDApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SamplesController : ControllerBase
    {
        private readonly IDataService _dataService;

        public SamplesController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public async Task<IActionResult> Get() { 
            List<DataModel> data = await _dataService.GetAllData();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetName(int id)
        {
            string data = await _dataService.GetName(id);
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Add(DataModel data)
        {
            await _dataService.AddData(data);
            return Ok($"Data Added Successfully: {data}");
        }
    }
}
