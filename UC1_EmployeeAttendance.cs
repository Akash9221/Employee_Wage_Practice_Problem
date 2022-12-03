using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    class UC1_EmployeeAttendance
    {
        public static void EmployeeAttendances()
        {
            //Constant
            int ISFULLTIME = 0;
            Random random = new Random();//Create A Object
            int empcheck=random.Next(0,2);
            if(empcheck==0)//Checking Condition 
            {
                Console.WriteLine("Employee Is Present");
            }
            else
            {
                Console.WriteLine("Employee Is Absent");
            }
        }
    }
}
 