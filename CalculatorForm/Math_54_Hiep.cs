using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorForm
{
    public class Math_54_Hiep
    {
        public static double Power_54_Hiep(double x_54_Hiep, int n_54_Hiep)
        {
            if (n_54_Hiep == 0)
                return 1;
            else if (n_54_Hiep < 0)
                return 1 / Power_54_Hiep(x_54_Hiep, -n_54_Hiep);
            else
                return x_54_Hiep * Power_54_Hiep(x_54_Hiep, n_54_Hiep - 1);
        }
    }
}
