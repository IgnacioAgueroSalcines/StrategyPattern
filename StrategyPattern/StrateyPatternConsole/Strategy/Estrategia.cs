using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public abstract class Estrategia
    {
        public abstract String filtro(String s);

        /// <summary>
        /// Elimina los acentos de una cadena
        /// </summary>
        /// <param name="inputString">Texto con acentos</param>
        /// <returns>Texto sin acentos</returns>
        public string QuitAccents(string inputString)
        {
            Regex a = new Regex("[á|à|ä|â]", RegexOptions.Compiled);
            Regex e = new Regex("[é|è|ë|ê]", RegexOptions.Compiled);
            Regex i = new Regex("[í|ì|ï|î]", RegexOptions.Compiled);
            Regex o = new Regex("[ó|ò|ö|ô]", RegexOptions.Compiled);
            Regex u = new Regex("[ú|ù|ü|û]", RegexOptions.Compiled);
            Regex n = new Regex("[ñ|Ñ]", RegexOptions.Compiled);
            inputString = a.Replace(inputString, "a");
            inputString = e.Replace(inputString, "e");
            inputString = i.Replace(inputString, "i");
            inputString = o.Replace(inputString, "o");
            inputString = u.Replace(inputString, "u");
            inputString = n.Replace(inputString, "n");
            return inputString;
        }
    }
}
