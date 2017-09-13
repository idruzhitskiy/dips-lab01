using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab01.Logic;

namespace Lab01.Controllers
{
    [Route("api/")]
    public class ValuesController : Controller
    {
        ISimpleLogic simpleLogic;
        public ValuesController(ISimpleLogic simpleLogic)
        {
            this.simpleLogic = simpleLogic;
        }
        [HttpGet("inc/{number}")]
        public int Increment(int number)
        {
            return simpleLogic.Inc(number);
        }

        [HttpGet("sum/{num1}/{num2}")]
        public int Sum(int num1, int num2)
        {
            return simpleLogic.Sum(num1,num2);
        }
    }
}
