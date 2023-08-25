using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Exercice4
{
    public class NotFoundException : Exception
    {
        public NotFoundException() : base("Mot trop court") {  }
    }
}
