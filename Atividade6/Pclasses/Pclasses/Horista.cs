using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pclasses
{
    class Horista : Empregado
    {
        public Double HourCounter { get; set; }
        public Double HourlySalary { get; set; }
        public int MissedDays { get; set; }


        public override double GrossSalary()
        {
            return HourlySalary * HourCounter;
        }
    }
}
