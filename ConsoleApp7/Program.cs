using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            //DateTime myDate = DateTime.Now;

            //string myDay = myDate.DayOfWeek;

            //string firstName = " Bob ";

            //string lastName = " Tabor ";

            //string ans = string.Format(" Hello {0}, is your last name {1} ?", firstName, lastName);

            double ans = 50.00;

                ans = ans * .07259;

            string tax = string.Format(" Total Tax {0:C}", ans);

            Console.WriteLine(tax);









        }
    }
}
