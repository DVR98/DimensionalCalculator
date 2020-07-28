using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.CalculateAnswer
{
    public class CalculateAnswer
    {
        int total;
        string sign;
        int number;

        public CalculateAnswer(int Total, int Number, string Sign)
        {
            total = Total;
            number = Number;
            sign = Sign;
        }

        public int Answer()
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
