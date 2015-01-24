using CSharpExercises.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharpExercises.Controllers
{
    public class ExercisesController : Controller
    {

        [HttpGet]
        public ActionResult Max()
        {
            return View();
        }


        public ActionResult Max(string numbers)
        {
            var mathinator = new Mathinator(numbers.Split(','));

            var result = new MaxViewModel
            {
                numbers = mathinator.nums,
                max = mathinator.Max()
            };

            return View(result);
        }

        [HttpGet]
        public ActionResult Sum()
        {
            return View();
        }

        public ActionResult Sum(string numbers)
        {
            var mathinator = new Mathinator(numbers.Split(','));

            var result = new SumViewModel
            {
                numbers = mathinator.nums,
                sum = mathinator.Sum()
            };

            return View(result);
        }

        [HttpGet]
        public ActionResult Multiply()
        {
            return View();
        }

        public ActionResult Multiply(string numbers)
        {
            var mathinator = new Mathinator(numbers.Split(','));

            var result = new MultiplyViewModel
            {
                numbers = mathinator.nums,
                product = mathinator.Multiply()
            };

            return View(result);
        }

        [HttpGet]
        public ActionResult Factorial()
        {
            return View();
        }

        public ActionResult Factorial(int number)
        {
            var result = new FactorialViewModel
            {
                number = number,
                factorial = Mathinator.Factorial(number)
            };

            return View(result);
        }

        [HttpGet]
        public ActionResult Palindrome()
        {
            return View();
        }

        public ActionResult Palindrome(string word)
        {
            var result = new PalindromeViewModel {
                word = word, pal = Wordinator.Palindrome(word)
            };

            return View(result);
        }
        
        public ActionResult FizzBuzz()
        {
            var fizzyBuzz = new FizzBuzzModel { intArray = new int[100], strArray = "" };
            fizzyBuzz.fB();
            return View(fizzyBuzz);
        }

        public ActionResult FindLongestWord()
        {
            var text = "The cat in the hat was fat. He loves lamp.";
            var wordinator = new Wordinator(text);

            var result = new LongestWordViewModel
            {
                text = text,
                longest = wordinator.findLongestWord()
            };

            return View(result);
        }

        [HttpGet]
        public ActionResult FindAWord()
        {
            return View();
        }
        
        public ActionResult FindAWord(FindAWordPostModel model)
        {
            var text = model.text;
            var word = model.word;
            var wordinator = new Wordinator(text);

            var result = new FindAWordViewModel
            {
                text = text,
                word = word,
                totalWord = wordinator.FindAWord(word)
            };

            return View(result);
        }

        [HttpGet]
        public ActionResult TotalAlice()
        {
           return View();
        }

        public ActionResult TotalAlice(TotalAlicePostModel model)
        {
            var text = model.text;
            var word = model.findWord;
            var wordinator = new Wordinator(text = model.text);

            var result = new TotalAliceViewModel
            {
                text = text, findWord = word,
                total = wordinator.TotalAlice(word)
            };

            return View(result);
        }

        [HttpGet]
        public ActionResult WordFrequency()
        {
            return View();
        }

        [HttpPost]
        public ActionResult WordFrequency(string text)
        {
            var words = new Wordinator(text);

            var modela = new WordFrequencyViewModel
            {
                text = text,
                frequencies = words.WordFrequency()
            };

            return View(modela);
        }

        [HttpGet]
        public ActionResult PerfectNumber()
        {
            return View();
        }

        public ActionResult PerfectNumber(int num)
        {
            var result = new PerfectNumberViewModel { perfectNum = num, perfect = Mathinator.PerfectNumber(num)};

            return View(result);
        }
    }
}