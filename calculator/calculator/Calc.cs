using System;
using System.Collections.Generic;
using System.Text;

namespace calculator
{
    class Calc
    {
        
        public static string Calculator (double a,double b,char opr)
            {
            string csrt = " ";
            switch (opr)
                {
                case '+': csrt = Convert.ToString(a + b); break;
                case '-': csrt = Convert.ToString(a - b); break;
                case '/': 
                  {
                        if (b != 0)
                        {
                            csrt = Convert.ToString(a / b); break;
                        }

                        else
                        {
                            csrt = " Divide by zero exception"; break;
                        }
                    }
                case '*': csrt = Convert.ToString(a * b); break;
                
                }
            return csrt;
            }
    }
}
