using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab01.Controllers
{
    [Route("api/")]
    public class ValuesController : Controller
    {
        [HttpGet("inc/{number}")]
        public string Increment(int number)
        {
            return (number + 1).ToString();
        }

        [HttpGet("sum/{num1}/{num2}")]
        public string Sum(int num1, int num2)
        {
            return (num1 + num2).ToString();
        }
    }
}
