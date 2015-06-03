using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam_Intro_0._2._1_TextEditor.Classes;
using Epam_Intro_0._2._1_TextEditor.Interfaces;
using System.Text.RegularExpressions;

namespace Epam_Intro_0._2._1_TextEditor.Parsers
{
    public class SentenceParser: IParser<Sentence>
    {
        public List<Sentence> Parse(string val)
        {
            //var sentences = Regex.Split(val, @"(?<=[\.!?])\s+");

            var sentences = new List<string>();
            bool isEnd = false;

            StringBuilder sb = new StringBuilder();
            foreach (char c in val)
            {
                if (!isEnd)
                {
                    sb.Append(c);
                }
                else
                {
                    if (char.IsUpper(c))
                    {
                        sentences.Add(sb.ToString());
                        sb = new StringBuilder();
                        sb.Append(c);
                        isEnd = false;
                    }
                    else if(char.IsPunctuation(c))
                    {
                        sb.Append(c);
                    }
                }
                if (c == '.' || c == '!' || c == '?')
                {
                    isEnd = true;
                }
            }
            //foreach (string s in sentences)
            //{
            //    Console.WriteLine(s);
            //}
            return sentences.Select(sentence => new Sentence(sentence)).ToList();
        }
    }
}
