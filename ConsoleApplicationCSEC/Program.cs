using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationCSEC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get user input
            Console.Write("Number of hours: ");
            int iHours = int.Parse(Console.ReadLine());

            //Assigning variables
            int iWeek = iHours / 168;
            int iHourLeft = iHours % 168;
            int iDay = iHourLeft / 24;
            int iHour1 = iHourLeft % 24;

            Console.WriteLine(iWeek + " weeks " + iDay +  " Days "  + iHour1 );

            string s = (iHour1 > 1) ? " Hours" : " Hour";

            Console.WriteLine("Press any key to exit: ");
            Console.ReadKey();
        }//Main
    }//Class
}//Nmaespace
