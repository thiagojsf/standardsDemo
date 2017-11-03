using System;
using System.Collections.Generic;
using System.Text;

namespace Demonstration
{
    public partial class Person
    {

        public List<Feeling> Feelings;

        public virtual bool CanDevelop()
        {
            throw new NotADevelopeException();
        }

        public void Eat()
        {

        }
    }
}
