using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class UC3_AddPartTime
    {
        public static void AddPartTime()
        {
            //Constant
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 0;
            int EMP_RATE_PER_HOUR = 20;

            //Varaible
            int emphr = 0;
            int empwage = 0;
            Random random = new Random();

            int empcheck = random.Next(0, 3);

            //Checking Conditions
            if(empcheck==IS_PART_TIME)
            {
                emphr = 4;
            }
            else if(empcheck==IS_FULL_TIME)
            {
                emphr = 8;
            }
            else
            {
                emphr = 0;
            }
            empwage = emphr * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage ="+empwage);
        }
    }
}
