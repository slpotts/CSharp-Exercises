using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharpExercises.Models
{
    public class Mathinator
    {
        public int[] nums { get; set; }

        public Mathinator()
        {

        }

        public Mathinator(string[] numbers)
        {
            List<int> temp = new List<int>();

            foreach (var word in numbers)
            {
                int t;
                if (Int32.TryParse(word, out t))
                    temp.Add(t);
            }
            nums = temp.ToArray();
        }

        public int Max() {
            int maxNum = 0;

            foreach (var number in nums)
            {
                if (number > maxNum)
                    maxNum = number;
            }
            

            return maxNum;
        }

        public int Sum()
        {
            int total = 0;

            foreach (var number in nums)
            {
                total += number;
            }

            return total;
        }

        public int Multiply()
        {
            int product = 1;

            foreach (var number in nums)
            {
                product = product * number;
            }

            return product;
        }

        public static int Factorial(int num)
        {
            int fact = num;
            int toral = fact;

            while (fact > 1)
            {
                toral = toral * (fact - 1);
                fact--;
            }
            return toral;
        }

        public static bool PerfectNumber(int num)
        {
            int[] pArray = new int[0];
            int arrayLoc = 0;

            for (int i = 1; i < num; i++) {
                if (num % i == 0) {
                    pArray[arrayLoc] = i;
                    arrayLoc++;
                }
            }

            var sum = 0;

            for (int b = 0; b < pArray.Length; b++) {
                sum += pArray[b];
            }

            if (sum == num) {
                return true;
            }
            else {
                return false;
            }
        }
    }
}