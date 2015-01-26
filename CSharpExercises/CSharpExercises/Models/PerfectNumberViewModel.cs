using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharpExercises.Models
{
    public class PerfectNumberViewModel
    {
        public int perfectNum { get; set; }
        public bool perfect { get; set; }
        public string perfectNumbers { get; set; }
    }

    public class PerfectNumberPostModel
    {
        public int perfectNum { get; set; }
    }
}