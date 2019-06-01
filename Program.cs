using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 12345;
            int output = 0;
            output = ReverseNumber(number);
            number = -6789;
            output = ReverseNumberFunction(number);
        }

        private static int ReverseNumber(int input)
        {
            int length = input.ToString().Length;
            int output = 0;         
            int pow = length-1;
          

            string rev = input.ToString();
            string newString = string.Empty;
            foreach(char val in rev)
            {
                newString = val + newString;
            }
            

            for(int i = 0; i < length; i++)
            {             
                output = (int)(output + (Int32.Parse(newString[i].ToString()) * (Math.Pow(10,pow))));
                pow--;

            }

            return output;

        }

        private static int ReverseNumberFunction(int input)
        {           
            int length = input.ToString().Length;
            if(input.ToString()[0] == '-')
            {
                length = length - 1;
            }
            int div = 0;
            int mod = 0;
            int output = 0;
            int pow = length - 1;


            for (int i = 0; i < length; i++)
            {
                div = (int)(input / Math.Pow(10, 1));
                mod = (int)(input % Math.Pow(10, 1));

                output = (int)(output + (mod * (Math.Pow(10, pow))));
                input = div;
                pow--;

            }

            return output;

        }
    }
}
