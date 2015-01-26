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
            List<int> pArrayL = new List<int>();

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0) 
                {
                    pArrayL.Add(i);
                }
            }

            int[] pArray = pArrayL.ToArray();

            int sum = 0;

            for (int b = 0; b < pArray.Length; b++) 
            {
                sum += pArray[b];
            }

            if (sum == num) 
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public static string AllPerfect()
        {
            List<int> allL = new List<int>();

            for (int i = 1; i <= 10000; i++) 
            {
                if (PerfectNumber(i))
                {
                    allL.Add(i);
                }
            }

            int[] all = allL.ToArray();
            string perfects = string.Join(", ", all);
            return perfects;
        }

        public static int sumPowered(int num, int pow)
        {
            int sum = 0;
            List<int> numsL = new List<int>();
            while (num > 0)
            {
                numsL.Add(num % 10);
                num = num / 10;
            }
            int[] nums = numsL.ToArray();
            sum = 0;
            for (int a = 0; a < nums.Length; a ++ )
            {
                sum += Convert.ToInt32(Math.Pow(Convert.ToDouble(nums[a]), Convert.ToDouble(pow)));
            }

            return sum;
        }

        private static bool isHappy(int number) 
        {
            List<int> seen = new List<int>();
            int contains;
            do {
                number = sumPowered(number, 2);
                contains = 0;
                if (seen.IndexOf(number) >= 0)
                    contains = 1;
                if (contains == 0) {


                    if (number == 1)
                        return true;

                    seen.Add(number);
                }
                else {
                    return false;
                }
            }
            while (number != 1);

            return false;
        }

        public static string happyNumbers() {
            List<int> happyArrayL = new List<int>();
            int hn = 1;

            while (happyArrayL.Count() < 5) {
                if (isHappy(hn))
                    happyArrayL.Add(hn);
                hn++;
            }

            int[] happyArray = happyArrayL.ToArray();
            string happyNums = string.Join(", ", happyArray);

            return happyNums;
        }

        public static string armstrongNumbers()
        {
            List<int> armNumL = new List<int>();
            int armNumber = 100;
            int armTotal;

            while (armNumber < 1000) {
                armTotal = sumPowered(armNumber, 3);
                if (armTotal == armNumber) {
                    armNumL.Add(armNumber);
                }
                armNumber++;
            }

            int[] armNums = armNumL.ToArray();
            string armNum = string.Join(", ", armNums);
            return armNum;
        }
    }
}