using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eGym.Models
{
    public class Measurement
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }
        public double Weight { get; set; }

        public double Height { get; set; }

        public virtual ApplicationUser User { get; set; }

        public BMI BMIData { get { return new BMI() { Masa = Weight, Wzrost = Height }; } }
    }
}
