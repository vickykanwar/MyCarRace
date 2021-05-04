using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCarRace.CarRaceModule
{
    public static class Factory
    {
        public static Punter GetPunter(string pun)
        {
            if(pun.Equals("Sophie"))
            {
                return new Sophie() { Name = "Sophie", Cash = 50 };
            }
            else if(pun.Equals("Ruby"))
            {
                return new Ruby() { Name = "Ruby", Cash = 50 };
            }
            else if (pun.Equals("Vicky"))
            {
                return new Vicky() { Name = "Vicky", Cash = 50 };
            }
            else
            {
                return null;
            }
        }
    }
}
