using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab01.Logic
{
    public class SimpleLogic : ISimpleLogic
    {
        public int Inc(int a)
        {
            return ++a;
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
