using MathController.Interface;
using MathController.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MathController.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MathController : ControllerBase
    {

        private readonly ILogger<MathController> _logger;
        private IMath MathObj = new MathClass();
        public MathController(ILogger<MathController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("/Add")]
        public double GetAdd()
        {
            return MathObj.Add(4, 5);
        }
        [HttpGet]
        [Route("/Substract")]
        public double GetSubstract()
        {
            return MathObj.Substract(6,2);
        }
        [HttpGet]
        [Route("/Multiply")]
        public double GetMultiply()
        {
            return MathObj.Multiply(7, 5);
        }
        [HttpGet]
        [Route("/Divide")]
        public double GetDivide()
        {
            return MathObj.Divide(45, 5);
        }
    }
}