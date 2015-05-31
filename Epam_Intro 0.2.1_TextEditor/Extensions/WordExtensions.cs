using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam_Intro_0._2._1_TextEditor.Classes;

namespace Epam_Intro_0._2._1_TextEditor.Extensions
{
    public static class WordExtensions
    {
        public static IEnumerable<Word> SelectByLenght(this IEnumerable<Word> list, int wordLenght)
        {
            return list.Distinct().Where(x => x.Length == wordLenght).ToList();
        }
    }
}
