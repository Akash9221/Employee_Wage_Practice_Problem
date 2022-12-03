using System;

namespace EmployeeManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //UC1
             UC1_EmployeeAttendance.EmployeeAttendances();
             Console.ReadLine();

            //UC2
             UC2_EmployeeWage.EmployeeWage();    
             Console.ReadLine();

            //UC3
             UC3_AddPartTime.AddPartTime();
             Console.ReadLine();

            //UC4
             Employee_Wage_Uc4.EmployeeWages();
             Console.ReadLine();
          
            //UC5
             UC5_Cal_Wage_Month.MonthWage();
             Console.ReadLine();
 
            //UC6
             UC6_Working_Days100.WorkingDays();
             Console.ReadLine();

            //UC7
             UC7_Refactor.ComputeEmpWage();
             Console.ReadLine();

            //UC8
            UC8_Multiple_Company.ComputeEmpWage("TCS", 22, 25, 20);
          UC8_Multiple_Company.ComputeEmpWage("Infosys", 15, 26, 24);
            Console.ReadLine();

            //UC9
            UC9_Ablity_To_Save  Amazon = new UC9_Ablity_To_Save("Amazon", 30, 25, 20);
            UC9_Ablity_To_Save Infosys = new UC9_Ablity_To_Save("Infosys", 25, 22, 29);
            Amazon.CompanyEmpWage();
            Console.WriteLine(Amazon.toString());
            Infosys.CompanyEmpWage();
            Console.Write(Infosys.toString());

            //UC10
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("TCS", 20, 4, 150);
            empWageBuilder.addCompanyEmpWage("Amazon", 25, 7, 200);
            empWageBuilder.addCompanyEmpWage("Infosys", 23, 3, 100);
            empWageBuilder.addCompanyEmpWage("Wipro", 28, 4, 160);
            empWageBuilder.addCompanyEmpWage("Hansen", 15, 2, 180);
            empWageBuilder.addCompanyEmpWage("Reliance", 25, 7, 240);
            empWageBuilder.addCompanyEmpWage("Apple", 40, 5, 260);
            empWageBuilder.computeEmpWage();

            //UC11
            EmpWageArray empWageBuilder = new EmpWageArray();
            empWageBuilder.addCompanyEmpWage("TechMahindra", 25, 7, 160);
            empWageBuilder.addCompanyEmpWage("LG", 23, 3, 100);
            empWageBuilder.addCompanyEmpWage("Wipro", 28, 4, 160);
            empWageBuilder.computeEmpWage();
        }
    }
}
