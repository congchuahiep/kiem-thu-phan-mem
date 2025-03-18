using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH1_54_Hiep
{
    public class Calculation_54_Hiep
    {
        private int a, b;

        public Calculation_54_Hiep(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int Execute(string calSymbol)
        {
            int result = 0;
            switch (calSymbol)
            {
                case "+":
                    result = this.a + this.b;
                    break;
                case "-":
                    result = this.a - this.b;
                    break;
                case "*":
                    result = this.a * this.b;
                    break;
                case "/":
                    result = this.a / this.b;
                    break;
            }

            return result;
        }
    } 
}
