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
        public ActionResult Sum()
        {
            /*if (model != null)
                model.SetSum();*/
            return View();
        }

        [HttpPost]
        public ActionResult Sum(SumPostModel model)
        {
            var responseModel = new SumViewModel { number1 = model.number1, number2 = model.number2 };

            responseModel.SetSum();
            return View(responseModel);
        }

        [HttpGet]
        public ActionResult MaxOfThree()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MaxOfThree(MaxPostModel model)
        {
            var maxThreeModel = new MaxViewModel { n1 = model.n1, n2 = model.n2, n3 = model.n3 };

            maxThreeModel.GetMax();
            return View(maxThreeModel);
        }

        public ActionResult FizzBuzz()
        {
            var fizzyBuzz = new FizzBuzzModel { };

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
        public ActionResult TotalAlice()
        {
           return View();
        }

        public ActionResult TotalAlice(TotalAlicePostModel model)
        {
            var text = model.text;
            var wordinator = new Wordinator(text = model.text);

            var result = new TotalAliceViewModel
            {
                text = text,
                total = wordinator.TotalAlice()
            };

            return View(result);
        }
    }
}