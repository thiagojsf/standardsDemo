using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Demonstration
{
    public class LinqExample
    {

        public readonly int MaxAvailableHours = 100;

        public static List<Employee> Employees;

        public void GenerateSprint()
        {

            var remainingHours = MaxAvailableHours;

            var manager = new Manager();
            var developer = new Developer();

            foreach(var task in manager.GetSprintTaskList())
            {
                remainingHours -= developer.EstimateTaskHours(task);
            }

            var myDevelopers = Employees.Where(y => y.CanDevelop());

            var psychopaths = Employees.Where(y => y.Feelings.Count() == 0);

            var firstDeveloperOfCompany = Employees.OrderBy(y => y.FirstWorkDay).FirstOrDefault();

            var lastFiveEmployeeHired = Employees.OrderByDescending(y => y.FirstWorkDay).Take(5);


        }
    }
}
