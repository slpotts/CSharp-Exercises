using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharpExercises.Models
{
    public class FizzBuzzModel
    {
        public int[] intArray = new int[100];
        public string strArray = "";

        public void fB() {
            for (int i = 0; i < 100; i++)
            {
                intArray[i] = i+1;
            }

            foreach (var number in intArray)
            {
                if (number % 3 == 0)
                {
                    if (number % 5 == 0)
                        strArray += "FizzBuzz ";
                    else
                        strArray += "Fizz ";
                }
                else if (number % 5 == 0)
                    strArray += "Buzz ";
                else
                    strArray+= number.ToString() + " ";
            }
        }

    }
}