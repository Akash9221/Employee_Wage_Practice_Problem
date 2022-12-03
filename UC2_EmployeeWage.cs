using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class UC2_EmployeeWage
    {
        public static void EmployeeWage()
        {
            //Constant
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
           
            //Variables
            int emphr = 0;
            int empwage = 0;

            Random random = new Random();//Create A Object
            int empcheck=random.Next(0,2);
            if(empcheck==IS_FULL_TIME)//Checking Conditions
            {
                emphr = 8;
            }
            else
            {
                emphr = 0;
            }
            empwage = emphr * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage=" +empwage);

        }
    }
}
