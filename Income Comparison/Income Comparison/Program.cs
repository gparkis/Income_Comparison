using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Income_Comparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("     *******************");
            Console.WriteLine("");
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("");
            Console.WriteLine("     *******************");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Person 1");
            Console.Write("   Please enter your hourly rate: $");
            double hourlyRate1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("   Please enter your weekly hours worked: ");
            double weeklyHoursWorked1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("     *******************");
            Console.WriteLine("");
            Console.WriteLine("Person 2");
            Console.Write("   Please enter your hourly rate: $");
            double hourlyRate2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("   Please enter your weekly hours worked: ");
            double weeklyHoursWorked2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("     *******************");
            Console.WriteLine("");

            Console.WriteLine("     PERSON 1: Annual Salary ");
            Console.WriteLine("_________________________________");
            Console.WriteLine("");
            Console.WriteLine("     $" + hourlyRate1 * weeklyHoursWorked1 * 52);
            Console.WriteLine("");
            Console.WriteLine("     *******************");
            Console.WriteLine("");
            Console.WriteLine("     PERSON 2: Annual Salary ");
            Console.WriteLine("_________________________________");
            Console.WriteLine("");
            Console.WriteLine("     $" + hourlyRate2 * weeklyHoursWorked2 * 52);
            Console.WriteLine("");
            Console.WriteLine("     *******************");
            Console.WriteLine("");

            bool person1MakeMore = (hourlyRate1 * weeklyHoursWorked1) > (hourlyRate2 * weeklyHoursWorked2);
            Console.WriteLine("Does Person 1 make more money than Person 2? ");
            Console.WriteLine("   " + person1MakeMore);

            Console.Read();
        }
    }
}
