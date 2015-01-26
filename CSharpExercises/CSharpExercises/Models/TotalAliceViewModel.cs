using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace CSharpExercises.Models
{
    public class TotalAliceViewModel
    {
        public string text { get; set; }
        public string findWord { get; set; }
        public int total { get; set; }
    }

    public class TotalAlicePostModel
    {
        public HttpPostedFileBase fileUpload { get; set; }
        public string text;
        public string findWord { get; set; }        
    }
}