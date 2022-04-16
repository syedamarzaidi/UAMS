using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uni.UI
{
    class MainUI
    {
       public static string Menu()
        {
            Console.WriteLine("1_ Add Student");
            Console.WriteLine("2_Add Degree Program");
            Console.WriteLine("3_Generate Merit");
            Console.WriteLine("4_View Registered Students");
            Console.WriteLine("5_view Students of Specific Program");
            Console.WriteLine("6_Register Subjects for Specific Student");
            Console.WriteLine("7_ Calculate fess for all registerd Subjects");
            Console.WriteLine("8_Exit");
            Console.WriteLine("Enter your Option:");
            string option = Console.ReadLine();
            return option;
        }
        public static void tempStop()
        {
            Console.WriteLine("Please Enter any key to Continue.........");
            Console.ReadKey();
            Console.Clear();
        }
        public static void header()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("                      UAMS                        ");
            Console.WriteLine("**************************************************");   
        }
    }
}
