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

            res= s.Replace("ñ", "ny");
            return base.QuitAccents(res);
        }
    }
}
