using System;
using System.Collections.Generic;
using System.Text;

namespace Demonstration
{
    public sealed class Manager : Employee
    {

        public readonly int DailyWorkHours = 8;

        public const bool ISBOSS = true;

        public override void Work()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WorkTask> GetSprintTaskList()
        {

            foreach (var task in GetSecurityTaskList())
            {
                yield return task;
            }

            foreach (var task in GetTaskListFromCustomer())
            {
                if (task.IsCritical)
                    yield return task;
            }

            foreach (var task in GetInternalTaskList())
            {
                if (task.IsCritical)
                    yield return task;
            }

        }

        public List<WorkTask> GetTaskListFromCustomer()
        {
            return new List<WorkTask>();
        }

        public List<WorkTask> GetInternalTaskList()
        {
            return new List<WorkTask>();
        }

        public List<WorkTask> GetSecurityTaskList()
        {
            return new List<WorkTask>();
        }

    }
}
