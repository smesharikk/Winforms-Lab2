using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class F_sin: IFunction
    {
        public double calc(double x)
        {
            return (Math.Sin(x));
        }
    }
}
