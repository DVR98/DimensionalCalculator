using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.CalculateAnswer
{
    public class CalculateAnswer
    {
        float total;
        string sign;
        float number;

        public CalculateAnswer(float Total, float Number, string Sign)
        {
            total = Total;
            number = Number;
            sign = Sign;
        }

        public float Answer()
        {
            if (sign == "+")
            {
                total += number;
            }
            else if (sign == "-")
            {
                total -= number;
            }
            else if (sign == "*")
            {
                total *= number;
            }
            else if (sign == "/")
            {
                total /= number;
            }

            return total;
        }
    }
}
