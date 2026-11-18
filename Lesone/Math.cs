using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesone
{
    internal class Math
    {
        public double Max(int[] number) { 
        double max = number[0];
            foreach (int number in numbers)
            {
                if (number > max)
                    max = number;

            }
            return max;
        }

        public double Min(int[] number) {
            double min = number[0];
            foreach (int number in numbers)
            {
                if (number > min)
                    min = number;
            }
            return min;
    }

        public double Min(int[] number)
        {
            double min = number[0];
            foreach (int number in numbers)
            {
                if (number > min)
                    min = number;
            }
            return min;
        }


    }

