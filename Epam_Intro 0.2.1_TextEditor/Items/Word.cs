using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_Intro_0._2._1_TextEditor.Classes
{
    public class Word
    {
        public string Value { get; set; }
        public int Length { get { return Value.Length; } }

        public Word(string val)
        {
            Value = val;
        }
    }
}
