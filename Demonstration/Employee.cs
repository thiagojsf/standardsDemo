using System;
using System.Collections.Generic;
using System.Text;

namespace Demonstration
{
    public abstract class Employee : Person
    {
        public DateTime FirstWorkDay;

        public abstract void Work();
    }
}
