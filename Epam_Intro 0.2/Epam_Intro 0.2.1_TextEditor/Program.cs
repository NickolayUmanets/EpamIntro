using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Epam_Intro_0._2._1_TextEditor
{
    class Program
    {
        public class Symbol
        {
            public class Letter
            {
                public List<string> _vowel = new List<string>()
            {
               "A", "a", "E", "e", "I", "i", "O", "o", "U", "u",  "Y", "y"
            };
                public List<string> _consonant = new List<string>()
            {
               "B", "b", "C", "c", "D", "d", "F", "f", "G", "g",  "H", "h",  "J", "j",  "K", "k", 
               "L", "l",  "M", "m",  "N", "n",  "P", "p",  "Q", "q", "R", "r", "S", "s", "T", "t",
               "V", "v", "W", "w", "X", "x", "Z", "z"
            };
                public List<string> _caseUpper = new List<string>()
            {
               "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q",
               "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
            };
                public List<string> _caseLower = new List<string>()
            {
               "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q",
               "r", "s", "t", "u", "v", "w", "x", "y", "z"
            };
            }
            public class Sign
            {
                public List<string> _sign = new List<string>()
            {
               " ", ".", ",", "!", "?", ";", ":", "'"
            };
            }

            public class WordSeparator
            {
                public List<string> _wordSeparator = new List<string>()
                {
                    " ",
                    " - "
                };
            }
            public class SentenceSeparator
            {
                public List<string> _sentenceSeparator = new List<string>()
                {
                    ". ", "! ", "? ", "!!! ", "?! ", ""
                };
            }
        };

        public class Word
        {
            List<Symbol.Letter> _word = new List<Symbol.Letter>();
        };

        public class Sentence
        {

        };

        static void Main(string[] args)
        {
            string initialtext = "Sentence one." +
                                 "Sentence, two?" +
                                 "Sentence three?" +
                                 "Sentence four, five six?" +
                                 "Sentence eight and nine and ten?" +
                                 "Last sentence!";
                               /*"Awesome manouver by Senna helps him to protect his position here at Adelaida, but his teammate and main competitor won't give up such early in the beggining of the race, so Prost will fight till the last turn and increase the pressure on Ayrton. How could you solve this riddle having no any hints and assumptions? Could you try to recall all the circumstances of what was happened last morning in the details? Take it easy, my fellow... Don't regret you fail, regret you fail so quick. Think twice before you kick him off! Congrats, see ya! His elevator doesn't go full way up. He is definately not the sharpest tool in the shed.";
                                */

            //int CountVowel = Regex.Matches(initialtext);
            int wordTotalCount = initialtext.Split(new Char[] { ' ', ',', '.', '!', '?', ':', ';' }).Count(x => x != "");
            string[] sentenceSplitter = { ".", "!", "?", "...", "?!", "!!!" };
            int sentenceCount = initialtext.Split(sentenceSplitter, StringSplitOptions.RemoveEmptyEntries).Count(x => x != "");
            
            Console.WriteLine(wordTotalCount);
            Console.WriteLine(sentenceCount);
            Console.ReadKey();

        }
    }
}
