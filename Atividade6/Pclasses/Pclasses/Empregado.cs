using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pclasses
{
    abstract class Empregado
    {
        //Atributes
        private int registrationNumber;
        private string employedName;
        private DateTime teamJoinTime;

        //Properties
        public int RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value; }
        }

        public string EmployedName
        {
            get { return employedName; }
            set { employedName = value; }
        }

        public DateTime TeamJoinTime
        {
            get { return teamJoinTime; }
            set { teamJoinTime = value; }

        }

        //Methods
        public abstract double GrossSalary();

        public virtual int TimeWorked()
        {
            TimeSpan ts = DateTime.Today.Subtract(TeamJoinTime);
            return ts.Days;
        }

    }
}
