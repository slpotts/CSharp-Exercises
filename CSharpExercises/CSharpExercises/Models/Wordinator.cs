using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

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

            words = words.Where(m => m != " " && m != "").ToArray();
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

        public string filterLongWords(int i)
        {
            List<string> longWords = new List<string>();
            string[] longWordsArray;

            foreach (var word in words) {
                if (word.Length >= i) {
                    if (!longWords.Contains(word))
                        longWords.Add(word);
                }
            }

            longWordsArray = longWords.ToArray();
            string allWords = string.Join(", ", longWordsArray);

            return allWords;
        }

        public int TotalAlice(string word)
        {
            int numAlice = 0;

            foreach (var aword in words)
            {
                if (aword.ToLower() == word.ToLower())
                {
                    numAlice++;
                }
            }

            return numAlice;
        }

        public Dictionary<string, int> WordFrequency()
        {
            var frequencies = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (frequencies.Keys.Contains(word))
                    frequencies[word]++;
                else
                    frequencies[word] = 1;
            }

            return frequencies;
        }

        public static bool Palindrome(string word)
        {
            string testWord = word.ToLower();
            char[] test = testWord.ToCharArray();
            Array.Reverse(test);
            testWord = new string(test);
            if (testWord == word.ToLower())
            {
                return true;
            }
            else
                return false;
        }
    }
}