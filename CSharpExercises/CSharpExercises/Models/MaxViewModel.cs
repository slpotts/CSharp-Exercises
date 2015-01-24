using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharpExercises.Models
{
    public class MaxViewModel
    {
        /*public int n1 { get; set; }
        public int n2 { get; set; }
        public int n3 { get; set; } */
        public int[] numbers { get; set; }
        public int max { get; set; }

        /*public void GetMax()
        {
            if (n1 >= n2)
            {
                if (n1 >= n3)
                    max = n1;
                else if (n3 > n1)
                    max = n3;
            }
            else if (n2 > n1)
            {
                if (n2 >= n3)
                    max = n2;
                else if (n3 > n2)
                    max = n3;
            }
        }*/
    }

    public class MaxPostModel
    {
        public string numbers { get; set; }
    }


}