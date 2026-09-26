// we use decimal instead of double because salary figures must be exact base-10 values without binary rounding errors.

using System;

class SalarySlip
{
    static void Main()
    {
        // 1. Ask for monthly basic salary 
        Console.WriteLine("Enter monthly basic salary: ");
        decimal basic = decimal.Parse(Console.ReadLine());

        // 2. Calculate components
        decimal hra = basic * 0.40m;   // 40% of basic
        decimal transport = 1600m;      //fixed allowance
        decimal pf = basic * 0.12m;     //12% deduction
        decimal professionalTax = 200m;  //fixed deductions

        //Totals 
        decimal totalEarnings = basic + hra + transport;
        decimal totalDeductions = pf + professionalTax;
        decimal netPay = totalEarnings - totalDeductions;

        // 3. Print formatted slip 
        Console.WriteLine("\n--------------------Salary Slip---------------------");
        Console.WriteLine("{0,-20}{1,15:N2}  {2,-20}{3,15:N2}",
                          "Basic Salarÿ", basic, "PF (12%)", pf);
        Console.WriteLine("{0,-20}{1,15:N2}  {2,-20}{3,15:N2}",
                          "HRA (40%)", hra, "Professional Tax", professionalTax);
        Console.WriteLine("{0,-20}{1,15:n2}", "Transport Allowance", transport);
        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("{0,-20}{1,15:N2}  {2,-20}{3,15:N2}",
                          "Total Earnings", totalEarnings, "Total Deductions", totalDeductions);
        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("{0,-20}{1,15:N2}", "Net Pay", netPay);
        Console.WriteLine("-------------------------------------------------------");

    }
}