using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesone
{
    public class Math
    {
        public double Max(int[] numbers)
        {
            double max = 0;
            foreach (int number in numbers)
            {
                if (number > max)
                    max = number;

            }
            return max;
        }

        public double Min(int[] numbers)
        {
            double min = numbers[0];
            foreach (int number in numbers)
            {
                if (number < min)
                    min = number;
            }
            return min;
        }



        public double Sum(int[] numbers)
        { 
            double sum = 0;
            foreach (int number in  numbers)
            {
                sum += number; 
            
            }
            return sum;
        
        
        }



        public double factorial(int number)
        { 
        double result= 1;
        for  (int i = number; i >= 1; i--)
                result *= i;
        return result;
        
        
        }

        public double CheckEvenOrOdd(int numbers)
        {
            if (numbers % 2 == 0)
            {
                return "Четное";
            }
            else
            {
                return "Нечетное";          
         
            }

        }

        public double GetAverage(int[] numbers)
        { 
        double sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
        
        }

        public IsPalindrome(string text)
        { 
        string lower = text.ToLower();
            string reversed = "";

            for (int i = lower.Length - 1; i >= 0; i--)
            {
                reversed += lower[i];
            }

            return lower == reversed;
        }
    
    }
}



