using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class Employee_Wage_Uc4
    {
        public static void EmployeeWages()
        {

            //Constant
            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 0;
            const int EMP_RATE_PER_HOUR = 20;

            //Variable
            int emphrs = 0;
            int empwage = 0;

            Random random = new Random();
            int empcheck = random.Next(0, 3);
            //Checking Condition 
            switch (empcheck)
            {
                case IS_FULL_TIME:
                    emphrs = 8;
                    break;

                case IS_PART_TIME:
                    emphrs = 4;
                    break;

                default:
                    emphrs = 0;
                    break;

            }
            empwage = emphrs * EMP_RATE_PER_HOUR;//Calculate Employee Wage
            Console.WriteLine("Emp Wage Is=" + empwage);
        }
    }
}
    
