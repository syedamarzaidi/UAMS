using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uni.BL;

namespace uni.UI
{
    class ProgramUI
    {
        public static void showPrograms()
        {
            Console.WriteLine("Available Degree Programs..........................................................");
            foreach (var stored in DegreeProgram.programSubjects)
            {
                Console.WriteLine(stored.title);
            }
        }
       public static DegreeProgram takeInputForDegree()
        {
            string title, duration,subjectType;
            int seats, subjectQuantity,subjectCode,subjectCreditHours,subjectFee;
            List<Subject> s = new List<Subject>();
            Console.WriteLine("Enter Degree title");
            title = Console.ReadLine();
            Console.WriteLine("Enter Degree Duration:");
            duration = Console.ReadLine();
            Console.WriteLine("Enter Degree Seats:");
            seats = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many subjects do you want to register:");
            subjectQuantity = int.Parse(Console.ReadLine());
            for (int i = 0; i < subjectQuantity; i++)
            {
                Subject temp_subject = SubjectsUI.takeInputForSubject();
                if (!s.Contains(temp_subject))
                {
                    s.Add(temp_subject);
                }
            }
            DegreeProgram p = new DegreeProgram(title,duration,seats,s);
            return p;
        }
    }
}
