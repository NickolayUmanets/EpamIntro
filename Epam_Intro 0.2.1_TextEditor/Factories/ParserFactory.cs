using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam_Intro_0._2._1_TextEditor.Classes;
using Epam_Intro_0._2._1_TextEditor.Interfaces;
using Epam_Intro_0._2._1_TextEditor.Parsers;

namespace Epam_Intro_0._2._1_TextEditor.Factories
{
    public class ParserFactory
    {
        public static IParser<T> CreateParser<T>()
        {
            Type type = typeof(T);
            if (type == typeof(Sentence))
                return (IParser<T>)new SentenceParser();
            else if (type == typeof(Word))
                return (IParser<T>)new WordParser();
            else if (type == typeof(Symbol))
                return (IParser<T>)new SymbolParser();
            else
                return null;
        }
    }
}
