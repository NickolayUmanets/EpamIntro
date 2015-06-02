using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam_Intro_0._2._1_TextEditor.Classes;

namespace Epam_Intro_0._2._1_TextEditor.Extensions
{
    public static class SentenceExtensions
    {
        public static IEnumerable<Sentence> SortSentencesByWordQuantity(this IEnumerable<Sentence> list)
        {
            return list.OrderBy(x => x.WordQuantity).ToList();
        }

        public static IEnumerable<Sentence> FindInterrogativeSentences(this IEnumerable<Sentence> list)
        {
            return list.Where(x => x.Value.Contains("?")).ToList();
        }
    }
}
