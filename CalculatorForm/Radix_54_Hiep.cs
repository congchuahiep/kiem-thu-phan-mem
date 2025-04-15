using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorForm
{
    public class Radix_54_Hiep
    {

        private int number_54_Hiep;

        public Radix_54_Hiep(int number_54_Hiep)
        {
            if (number_54_Hiep < 0)
                throw new ArgumentException("Incorrect Value");

            this.number_54_Hiep = number_54_Hiep;
        }

        public string ConvertDecimalToAnother_54_Hiep(int radix_54_Hiep = 2)
        {
            int n_54_Hiep = this.number_54_Hiep;

            if (radix_54_Hiep < 2 || radix_54_Hiep > 16)
                throw new ArgumentException("Invalid Radix");

            List<string> result_54_Hiep = new List<string>();
            while (n_54_Hiep > 0)
            {
                int value_54_Hiep = n_54_Hiep % radix_54_Hiep;

                if (value_54_Hiep < 10)
                    result_54_Hiep.Add(value_54_Hiep.ToString());
                else
                {
                    switch (value_54_Hiep)
                    {
                        case 10: result_54_Hiep.Add("A"); break;
                        case 11: result_54_Hiep.Add("B"); break;
                        case 12: result_54_Hiep.Add("C"); break;
                        case 13: result_54_Hiep.Add("D"); break;
                        case 14: result_54_Hiep.Add("E"); break;
                        case 15: result_54_Hiep.Add("F"); break;
                    }
                }

                n_54_Hiep /= radix_54_Hiep;
            }

            result_54_Hiep.Reverse();
            return String.Join("", result_54_Hiep.ToArray());
        }

    }
}
