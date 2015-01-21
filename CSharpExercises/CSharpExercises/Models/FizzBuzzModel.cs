using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharpExercises.Models
{
    public class FizzBuzzModel
    {
        public int[] intArray;
        public string[] strArray;
        public int passThrough;

        public void fB() {
            for (int i = 1; i <= 100; i++)
            {
                intArray[i - 1] = i;
            }

            foreach (var number in intArray)
            {
                if (number % 3 == 0)
                {
                    if (number % 5 == 0)
                        strArray[passThrough] = "FizzBuzz";
                    else
                        strArray[passThrough] = "Fizz";
                }
                else if (number % 5 == 0)
                    strArray[passThrough] = "Buzz";
                else
                    strArray[passThrough] = number.ToString();
                passThrough++;
            }
        }

    }
}