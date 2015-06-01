using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_Intro_0._2._1_TextEditor.Interfaces
{
    public interface IParser<T>
    {
        List<T> Parse(string val);
    }
}
