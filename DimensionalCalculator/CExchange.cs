using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimensionalCalculator
{
    public class CExchange
    {
        bool Dollar1, Rand1, Pound1, Euro1, Dollar2, Rand2, Pound2, Euro2;  //CExchange variables
        String In, Out;
        double rIn, rOut;

        //constructor:
        public CExchange(bool InDollar, bool InRand, bool InPound, bool InEuro, bool OutDollar, bool OutRand, bool OutPound, bool OutEuro, double rInput) //Constructor
        {
            Dollar1 = InDollar;
            Rand1 = InRand;
            Pound1 = InPound;
            Euro1 = InEuro;
            Dollar2 = OutDollar;
            Rand2 = OutRand;
            Pound2 = OutPound;
            Euro2 = OutEuro;
            rIn = rInput;
        }

        public String Convertion() //Returns the text for the Textbox
        {
            if (Dollar1 == true) //if the user chose to convert Dollar into:
            {
                if (Dollar2 == true)  //Dollar
                {
                    In = "Dollar: $";
                    rIn = rIn;
                    rOut = rIn;
                    Out = "Dollar: $";
                }

                else if (Rand2 == true)  //Rand
                {
                    In = "Dollar: $";
                    rIn = rIn;
                    rOut = rIn * 11.57;
                    Out = "Rand: R"; 
                }

                else if (Pound2 == true) //Pound
                {
                    In = "Dollar: $";
                    rIn = rIn;
                    rOut = rIn * 0.72;
                    Out = "Pound: £";
                }

                else if (Euro2 == true)  //Euro
                {
                    In = "Dollar: $";
                    rIn = rIn;
                    rOut = rIn * 0.81;
                    Out = "Euro: €";
                }
            
            }

            if (Rand1 == true) //If the user chose to convert Rand into:
            {
                if (Dollar2 == true) //Dollar
                {
                    In = "Rand: R";
                    rIn = rIn;
                    rOut = rIn * 0.086;
                    Out = "Dollar: $";
                }

                else if (Rand2 == true)  //Rand
                {
                    In = "Rand: R";
                    rIn = rIn;
                    rOut = rIn;
                    Out = "Rand: R";
                }

                else if (Pound2 == true)  //Pound
                {
                    In = "Rand: R";
                    rIn = rIn;
                    rOut = rIn * 0.062;
                    Out = "Pound: £";
                }

                else if (Euro2 == true)  //Euro
                {
                    In = "Rand: R";
                    rIn = rIn;
                    rOut = rIn * 0.070;
                    Out = "Euro: €";
                }

            }

            if (Pound1 == true) //if user chose to convert pound into:
            {
                if (Dollar2 == true) //Dollar
                {
                    In = "Pound: £";
                    rIn = rIn;
                    rOut = rIn * 1.40;
                    Out = "Dollar: $";
                }

                else if (Rand2 == true)  //Rand
                {
                    In = "Pound: £";
                    rIn = rIn;
                    rOut = rIn * 16.16;
                    Out = "Rand: R";
                }

                else if (Pound2 == true)  //Pound
                {
                    In = "Pound: £";
                    rIn = rIn;
                    rOut = rIn;
                    Out = "Pound: £";
                }

                else if (Euro2 == true)  //Euro
                {
                    In = "Pound: £";
                    rIn = rIn;
                    rOut = rIn * 1.129;
                    Out = "Euro: €";
                }

            }

            if (Euro1 == true) //If the user chose to convert Euro into:
            {
                if (Dollar2 == true)  //Dollar
                {
                    In = "Euro: €";
                    rIn = rIn;
                    rOut = rIn * 1.23;
                    Out = "Dollar: $";
                }

                else if (Rand2 == true)  //Rand
                {
                    In = "Euro: €";
                    rIn = rIn;
                    rOut = rIn * 14.22;
                    Out = "Rand: R";
                }

                else if (Pound2 == true)  //Pound
                {
                    In = "Euro: €";
                    rIn = rIn;
                    rOut = rIn * 0.88;
                    Out = "Pound: £";
                }

                else if (Euro2 == true) //Euro
                {
                    In = "Euro: €";
                    rIn = rIn;
                    rOut = rIn;
                    Out = "Euro: €";
                }

            }

            return In + rIn.ToString() + "\n" + "=" + "\n" +
                        Out + rOut.ToString(); //Returns the message to the TextBox
        }
    }
}
