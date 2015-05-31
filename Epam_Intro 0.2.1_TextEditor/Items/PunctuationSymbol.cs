using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_Intro_0._2._1_TextEditor.Classes
{
    public class PunctuationSymbol: Symbol
    {
        private readonly char[] symbols = new char[] { '.', ',', '!', '?', ':', ';' };

        public PunctuationSymbol(char val)
            : base(val)
        {
            if (symbols.Contains(val))
                Value = val;
        }
    }
}
