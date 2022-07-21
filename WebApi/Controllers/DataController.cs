using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataController : ControllerBase
    {
        private readonly ILogger<DataController> _logger;

        public DataController(ILogger<DataController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string GetSampleJsonData()
        {
            var fullPath = Path.Combine("", "Data/SampleData.json");

            var jsonData = System.IO.File.ReadAllText(fullPath);
            return jsonData;

        }

        [HttpPost]
        [Route("SaveData")]

        public IActionResult SaveJsonData(IFormCollection griddata)
        {
            var procs = JsonConvert.DeserializeObject<List<SecurityGroupProcedureForGridDto>>(griddata["gridData"]);
            return NoContent();

        }
    }
}