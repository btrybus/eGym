using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eGym.Models
{
    public class BMI
    {
        double masa;

        public double Masa
        {
            get
            {
                return masa;
            }
            set
            {
                masa = value;
            }
        }

        public double Wzrost { get; set; }
        public double WspolczynnikBMI => Masa / ((Wzrost / 100.0) * (Wzrost / 100.0));

        public string Opis
        {
            get
            {
                string opis = "OK :)";

                if (WspolczynnikBMI < 18.5)
                    opis = "Niedowaga";
                else if (WspolczynnikBMI > 30)
                    opis = "Otyłość";
                else if (WspolczynnikBMI >= 25)
                    opis = "Nadwaga";

                return opis;
            }
        }

    }
}
