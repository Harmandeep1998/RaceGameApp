using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceGameApp
{
    public class PunterFactory
    {
        public static Punter GetPunter(int number)
        {
            if (number == 1)
            {
                return new Oliver() { Cash = 50 };
            }
            else if (number == 2)
            {
                return new Noah() { Cash = 50 };
            }
            else if (number == 3)
            {
                return new Leo() { Cash = 50 };
            }
            else
            {
                return null;
            }
        }
    }
}
