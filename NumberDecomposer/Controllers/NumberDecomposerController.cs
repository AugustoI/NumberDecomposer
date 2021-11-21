using Microsoft.AspNetCore.Mvc;
using NumberDecomposer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberDecomposer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NumberDecomposerController : Controller
    {
        [HttpGet("DecomposeNumber/{N}")]
        //public IEnumerable<NumberDecomposition> DecomposeNumber(int N)
        public NumberDecomposition DecomposeNumber(int N)
        {
            try
            {
                List<NumberDecomposition> decompositionList = new List<NumberDecomposition>();
                NumberDecomposition decomposition = new NumberDecomposition();
                decomposition.Number = N;
                decompositionList.Add(decomposition);
                //return decompositionList.AsEnumerable();
                return decomposition;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error on DecomposeNumber Method: {e.Message}");
                throw e;
            }            
        }
    }
}
