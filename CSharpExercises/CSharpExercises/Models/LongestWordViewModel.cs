﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharpExercises.Models
{
    public class LongestWordViewModel
    {
        public string text { get; set; }
        public string longest { get; set; }
    }

    public class LongestWordPostModel
    {
        public HttpPostedFileBase fileUpload { get; set; }
    }
}