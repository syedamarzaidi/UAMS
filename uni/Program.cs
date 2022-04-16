using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uni.UI;
using uni.BL;
using uni.DL;
using uni.HELPER;
namespace uni
{
    class Program
    {
        static void Main(string[] args)
        {
            string option = "";
            bool programRunning = true;
            while (programRunning)
            {
                option = MainUI.Menu();
                if (option == "1")
                {
                    if (!Constraints.isProgramsListEmpty(DegreeProgram.programSubjects))
                    {
                        Student s = StudentUI.takeInputFroStudent();
                        StudentDL.addStudentToList(s);
                    }
                }
                else if (option == "2")
                {
                    DegreeProgram d = ProgramUI.takeInputForDegree();
                    ProgramDL.addDegreeToList(d);
                }
                else if (option == "3")
                {
                    List<Student> sortedStudents = StudentDL.sortStudents();
                    StudentDL.giveAddmission(sortedStudents);
                    StudentUI.showStudents();
                }
                else if (option    == "4")
                {
                    StudentUI.showStudents();
                }
                else if (option == "5")
                {
                    Console.WriteLine("Enter Degree Name....");
                    string title = Console.ReadLine();
                    StudentUI.showSpecificStudents(title);
                }
                else if (option == "6")
                {
                    Console.WriteLine("Enter Student Name....");
                    string name = Console.ReadLine();
                    Student s = Student.isStudentExits(name);
                    if (s != null)
                    {
                        SubjectsUI.viewSubjects(s);
                        SubjectDL.RegisterSubjects(s);
                    }
                }
                else if(option == "7")
                {
                    StudentUI.calculateFeeForAll();
                }
                MainUI.tempStop();
            }
        }
    }
}
