using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharpExercises.Models
{
    public class SumViewModel
    {
        public int[] numbers { get; set; }
        public int sum { get; set; }
    }

    public class SumPostModel
    {
        public string numbers { get; set; }
    }
}