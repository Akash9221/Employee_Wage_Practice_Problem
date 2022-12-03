using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class UC5_Cal_Wage_Month
    {
        public static void MonthWage()
        {
            //Constant
            const int isfulltime = 1;
            const int isparttime = 0;
            const int rateperhour = 20;
            const int dayinmonth = 22;

            //Variable
            int emphr = 0;
            int empwage = 0;
            int totalempwage = 0;

            for(int i=0; i<dayinmonth; i++)
            {
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                //Checking Condition
                switch(empcheck)
                {
                    case isfulltime:
                        emphr = 8;
                        break;

                    case isparttime:
                        emphr = 4;
                        break;

                    default:
                        emphr = 0;
                        break;
                }
                empwage = emphr *rateperhour;//Calculate Employee Wage
                totalempwage += empwage;
                Console.WriteLine("Emp Wage is=" +empwage);
            }
            Console.WriteLine("Total Emp wage=" +totalempwage);
        }
    }
}
