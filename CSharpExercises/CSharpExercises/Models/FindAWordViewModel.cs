using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharpExercises.Models
{
    public class FindAWordViewModel
    {
        public string text { get; set; }
        public string word { get; set; }
        public int totalWord { get; set; }
    }

    public class FindAWordPostModel
    {
        public string text { get; set; }
        public string word { get; set; }
    }
}