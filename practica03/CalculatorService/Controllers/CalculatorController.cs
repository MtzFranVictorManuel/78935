 using Microsoft.AspNetCore.Mvc;
using System.ServiceModel;
using CalculatorService.Models;

namespace CalculatorService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("sum/{num1}/{num2}")]
        public IActionResult Sum(int num1, int num2)
        {
            using (var client = new CalculatorServiceClient(new BasicHttpBinding(), new EndpointAddress("http://localhost:5000/CalculatorService.asmx")))
            {
                return Ok(client.Add(num1, num2));
            }
        }

        [HttpGet("subtract/{num1}/{num2}")]
        public IActionResult Subtract(int num1, int num2)
        {
            using (var client = new CalculatorServiceClient(new BasicHttpBinding(), new EndpointAddress("http://localhost:5000/CalculatorService.asmx")))
            {
                return Ok(client.Subtract(num1, num2));
            }
        }

        [HttpGet("multiply/{num1}/{num2}")]
        public IActionResult Multiply(int num1, int num2)
        {
            using (var client = new CalculatorServiceClient(new BasicHttpBinding(), new EndpointAddress("http://localhost:5000/CalculatorService.asmx")))
            {
                return Ok(client.Multiply(num1, num2));
            }
        }

        [HttpGet("divide/{num1}/{num2}")]
        public IActionResult Divide(int num1, int num2)
        {
            using (var client = new CalculatorServiceClient(new BasicHttpBinding(), new EndpointAddress("http://localhost:5000/CalculatorService.asmx")))
            {
                return Ok(client.Divide(num1, num2));
            }
        }
    }
}
