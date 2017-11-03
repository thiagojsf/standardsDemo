using System;
using System.Collections.Generic;
using System.Text;

namespace Demonstration
{
    public class Developer : Employee
    {

        public bool HasCoofee;

        private int codeLinesPerDay;

        public int CodeLinesPerDay {
            set => codeLinesPerDay = value;
            get
            {
                if (HasCoofee)
                    return codeLinesPerDay * 2;
                else
                    return codeLinesPerDay;
            }
            
        }

        public override void Work()
        {
            throw new NotImplementedException();
        }

        public override bool CanDevelop()
        {
            return true;
        }

        public int EstimateTaskHours(WorkTask task)
        {
            return 5;
        }

    }
}
