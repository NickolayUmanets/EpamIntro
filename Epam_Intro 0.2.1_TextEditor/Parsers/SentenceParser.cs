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
            var sentences = Regex.Split(val, @"(?<=[\.!\?])\s+");
            return sentences.Select(sentence => new Sentence(sentence)).ToList();
        }
    }
}
