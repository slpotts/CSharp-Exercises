using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharpExercises.Models
{
    public class Wordinator
    {
        public string text { get; set; }
        public string[] words { get; set; }

        public Wordinator()
        {

        }

        public Wordinator(string text)
        {
            this.text = text;

            var tempText = text.Replace('\n', ' ');
            tempText = tempText.Replace('.', ' ');
            words = tempText.Split(' ');
        }

        public string findLongestWord()
        {
            string longestWord = "";

            foreach (var word in words) {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }

            return longestWord;
        }

        public string[] filterLongWords(int i)
        {
            List<string> longWords = new List<string>();
            string[] longWordsArray;

            foreach (var word in words) {
                if (word.Length >= i) {
                    longWords.Add(word);
                }
            }

            longWordsArray = longWords.ToArray();

            return longWordsArray;
        }

        public string wordFreq()
        {
            return text;
        }

        public int TotalAlice()
        {
            int numAlice = 0;

            foreach (var word in words)
            {
                if (word == "Alice" || word == "alice")
                {
                    numAlice++;
                }
            }

            return numAlice;
        }
    }
}