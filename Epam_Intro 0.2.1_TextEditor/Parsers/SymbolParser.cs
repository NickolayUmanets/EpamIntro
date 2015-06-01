using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam_Intro_0._2._1_TextEditor.Classes;
using Epam_Intro_0._2._1_TextEditor.Interfaces;

namespace Epam_Intro_0._2._1_TextEditor.Parsers
{
    public class SymbolParser: IParser<Symbol>
    {
        public List<Symbol> Parse(string val)
        {
            return new List<Symbol>();
        }
    }
}
