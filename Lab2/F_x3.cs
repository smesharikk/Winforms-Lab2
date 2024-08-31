using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class F_x3: IFunction
    {
        public double calc(double x)
        {
            return (x * x * x);
        }
    }
}
