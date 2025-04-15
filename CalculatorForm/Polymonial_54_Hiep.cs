using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorForm
{
    public class Polymonial_54_Hiep
    {
        private int n_54_Hiep;
        private List<int> a_54_Hiep;

        public Polymonial_54_Hiep(int n_54_Hiep, List<int> a_54_Hiep)
        {
            if (a_54_Hiep.Count() != n_54_Hiep + 1)
            {
                throw new ArgumentException("Invalid Data");
            }

            this.n_54_Hiep = n_54_Hiep;
            this.a_54_Hiep = a_54_Hiep;
        }

        public double Calculate_54_Hiep(double x_54_Hiep)
        {
            double result_54_Hiep = 0;
            for (int i_54_Hiep = 0; i_54_Hiep <= this.n_54_Hiep; i_54_Hiep++)
            {
                result_54_Hiep += (int) (a_54_Hiep[i_54_Hiep] * Math_54_Hiep.Power_54_Hiep(x_54_Hiep, i_54_Hiep));
            }
            return result_54_Hiep;
        }
    }
}
