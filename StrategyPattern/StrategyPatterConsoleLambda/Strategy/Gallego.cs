using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Gallego:Estrategia
    {
        public override String filtro(String s)
        {//ñ por nh
            return s.Replace("ñ", "nh");
        }
       
    }
}
