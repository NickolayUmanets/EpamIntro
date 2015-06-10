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
    public class WordParser: IParser<Word>
    {
        public List<Word> Parse(string val)
        {
            //var withChangedSpecialSymbols = Regex.Replace(val, "[^a-zA-Z0-9% ._]", string.Empty).Split(' ');

            var withChangedSpecialSymbols = new List<string>();
            StringBuilder sb = new StringBuilder();
            foreach (char c in val)
            {
                if (!char.IsPunctuation(c) || c == '.')
                {
                    sb.Append(c);
                }
                else if (c == ' ')
                {
                    if (sb.Length > 0)
                    {
                        withChangedSpecialSymbols.Add(sb.ToString());
                        sb = new StringBuilder();
                    }
                }
            }
            if (sb.Length > 0)
            {
                withChangedSpecialSymbols.Add(sb.ToString());
            }

            return withChangedSpecialSymbols.Select(word => new Word(word)).ToList();
        }
    }
}
