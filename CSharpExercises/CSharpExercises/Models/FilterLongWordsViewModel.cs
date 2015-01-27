using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharpExercises.Models
{
    public class FilterLongWordsViewModel
    {
        public string text { get; set; }
        public int length { get; set; }
        public string longWords { get; set; }
    }

    public class FilterLongWordsPostModel
    {
        public HttpPostedFileBase fileUpload { get; set; }
        public int length { get; set; }
    }
}