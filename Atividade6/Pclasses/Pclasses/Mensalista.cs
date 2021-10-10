using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pclasses
{
    class Mensalista : Empregado
    {
        public Double MonthilySalary { get; set; }

        public override double GrossSalary()
        {
            return MonthilySalary;
        }
        public Mensalista()
        {

        }

        public Mensalista(int registx, string namex, DateTime datax, double salax)
        {

        }

        public int Soma(int x, int y)
        {
            return x + y;
        }

        public int Soma(int x, int y, int z)
        {
            return x + y + z;
        }
    }
}
 