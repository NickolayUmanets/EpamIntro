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
            var withChangedSpecialSymbols = Regex.Replace(val, "[^a-zA-Z0-9% ._]", string.Empty).Split(' ');
            return withChangedSpecialSymbols.Select(word => new Word(word)).ToList();
        }
    }
}
