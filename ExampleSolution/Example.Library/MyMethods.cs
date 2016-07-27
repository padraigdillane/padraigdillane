using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Library
{
    public class MyMethods
    {
        public static string ReverseWord(string input)
        {
            string output = string.Empty;
          

            //Check if word is null
            if (string.IsNullOrEmpty(input))
            {
                output = "empty";
            }
            else
            {
                char[] charArray = input.ToLower().ToCharArray();
                Array.Reverse(charArray);
                output = new string(charArray);
            }
           
            return output;
        }

        public static int Factorial(int input)
        {
            if (input == 2)
            {
                return 2;
            }

            if (input == 1)
            {
                return 1;
            }

            return input * Factorial(input -1);
        }

        public static int FactorialLoop(int input)
        {
            //ArrayList al = new ArrayList();
            int sum = 1;
            for (int i = input; i > 0; i--)
            {
                sum *= i;
            }

            return sum;
        }

        public static int Fib(int input)
        {
            int num1 = 0;
            int num2 = 1;
            int temp = 0;

            for (int i = 0; i < input; i++)
            {
                num1 = num2;
                num2 = temp;
                temp = num1+num2;
            }

            return temp;
        }

        public static int FibRecurssion(int input)
        {
            //in input step compute fib iteratively
            //add first and second and store 

            if (input == 0)
            {
                return 0;
            }

            if (input == 1)
            {
                return 1;
            }

            return FibRecurssion(input - 1) + FibRecurssion(input - 2);
        }

        public static int GetMax(int[] a)
        {
            int smallest = 0;

            //find max array
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > smallest)
                {
                    smallest = a[i];
                }

            }

            return smallest;
        }

        public static double PennyShade(double input)
        {

            //input 1.000134f returns 34;
            //Take float and take two digits of the end
            string s = input.ToString();
            //double a = 1.000134;

            string outputtoString = s.Substring(s.Length - 2);
            int output = Int32.Parse(outputtoString);
            
            return output;
        }
    }
}
