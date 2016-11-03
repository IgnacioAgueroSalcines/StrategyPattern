using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class InternacionalCatalan : Estrategia
    {
        public override String filtro(String s)
        {//ñ por ny
            String res = "";
            
            foreach (Char a in s)
            {
                if (a.Equals('ñ'))
                {
                    res += "ny";
                }else
                {
                    res += a;
                }
            }
            return base.QuitAccents(res);
        }
    }
}
