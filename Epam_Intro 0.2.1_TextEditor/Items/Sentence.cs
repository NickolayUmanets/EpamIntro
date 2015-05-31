using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_Intro_0._2._1_TextEditor.Classes
{
    public class Sentence
    {
        public string Value { get; set; }

        public int WordQuantity { get { return Value.Count(Char.IsWhiteSpace); } }

        public Sentence(string val)
        {
            Value = val;
        }
    }
}
