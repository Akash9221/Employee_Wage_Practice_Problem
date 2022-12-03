using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class UC6_Working_Days100
    {
        public static void WorkingDays()
        {
            //Constant
            const int isfulltime = 1;
            const int isparttime = 0;
            const int rateperhour = 20;
            const int workingdayinmonth = 22;
            const int maxhrinmonth = 100;

            //Variable
            int emphr = 0;
            int totalemphr = 0;
            int totalworking = 0;

            while (totalemphr <= maxhrinmonth && totalworking < workingdayinmonth)//Checking Condition
            {
                totalworking++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
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
                totalemphr += emphr;
                Console.WriteLine("days=" + totalworking + "Emp hrs=" + emphr);
            }
            int totalempwage = totalemphr * emphr;//Calculate Employee Wage
            Console.WriteLine("Total Emp Wage=" + totalempwage);
        }
    }
}
