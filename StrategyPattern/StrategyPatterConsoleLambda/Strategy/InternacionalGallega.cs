using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class InternacionalGallega:Estrategia
    {
        public override String filtro(String s)
        {//ñ por nh
            String res = "";
            res= s.Replace("ñ", "nh");
            return base.QuitAccents(res);
        }

        
    }
}
