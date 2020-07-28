using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimensionalCalculator
{
    public class CInterest  //class CInterest
    {
        private float Start, Interest, Part3;  //private and public variables
        private int Years;
        private bool Simple, Compound;
        public float EndAmount;
        float Part1, Part2, Part4; 
        int i;

        public CInterest(float StartAmount, float InterestRate, int AmountYears, bool Simpled, bool Compounded)  //Constructor
        {
            Start = StartAmount;
            Interest = InterestRate;
            Years = AmountYears;
            Simple = Simpled;
            Compound = Compounded;
        }

        public float CalculateInterest()
        {

            if (Simple == true)  //if the user chose to use simple interest, this calculation will occur
            {
                Part1 = Interest / 100;
                Part2 = Years * Part1;         //I'm breaking the A=P(1+i.n) or A=P(1+i)^n into four parts to make calculations easier and more accurate.
                Part3 = 1 + Part2;
                Part4 = Start * Part3;
                EndAmount = Part4;
                return EndAmount;
            }

            if (Compound == true)  //if the user chose to use compounded interest, this calculation will occur
            {
                Part1 = Interest / 100;
                Part2 = Part1 + 1;               //I'm breaking the A=P(1+i.n) or A=P(1+i)^n into four parts to make calculations easier and more accurate.
                Part3 = 1;
                for (i = 1; i <= Years; i++) //((1+i)*(1+i))*(1+i) ..... (1+i)^n
                {
                    Part3 *= Part2;
                }

                Part4 = Start * Part3;
                EndAmount = Part4;
                return EndAmount;  //Returns the calculated End amount
            }

            return EndAmount;
        }
    }

}
