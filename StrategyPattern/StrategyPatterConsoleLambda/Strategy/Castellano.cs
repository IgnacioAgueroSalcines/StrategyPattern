using StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrateyPatternConsole.Strategy
{
   public class Castellano:Estrategia
    {
        public override String filtro(String s)
        {
            return s;
        }
    }
}
