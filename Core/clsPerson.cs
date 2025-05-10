using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DeskEtu.Additional.clsStructs;

namespace DeskEtu.Core
{
    internal class clsPerson
    {
        protected clsPerson(stPerson Person)
        {
            this.Person = Person;
        }

        protected stPerson Person; 

    }
}
