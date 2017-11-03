using System;
using System.Collections.Generic;
using System.Text;

namespace Demonstration
{
    public class QA : Employee
    {

        public QA()
        {
            Tasks = new int[5];
        }

        ~QA()
        {
            Tasks = new int[0];
        }

        public int[] Tasks;

        public override void Work()
        {
            throw new NotImplementedException();
        }
    }
}
