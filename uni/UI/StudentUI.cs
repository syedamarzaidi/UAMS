using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uni.BL;

namespace uni.UI
{
    class StudentUI
    {
        
        public static Student takeInputFroStudent()
        {
            string name = "";
            int age = 0;
            float fscMarks = 0;
            float ecatMarks = 0;
            List<DegreeProgram> prefrences = null;
            Console.WriteLine("Enter Student Name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter Student Age:");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Fsc Marks");
            fscMarks = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Ecat Marks:");
            ecatMarks = float.Parse(Console.ReadLine());
            Console.WriteLine("How many Prefrences of you are ?");
            int prefrencesQuantity = int.Parse(Console.ReadLine());
            ProgramUI.showPrograms();
            Console.ReadKey();
            //This code is to input list containing prefrences
            Console.WriteLine("Enter Your Prefrence Subject:");
            for (int i = 0; i < prefrencesQuantity; i++)
            {
                bool flag = false;
                string temp_subject = Console.ReadLine();
                foreach (var d in DegreeProgram.programSubjects)
                {
                    if (d.title == temp_subject)// && (!prefrences.Contains(d)))
                    {
                        prefrences.Add(d);
                        flag = true;
                        break;  
                    }
                }
                if (!flag)
                {
                    Console.WriteLine("Enter Valid Degree Program");
                    i--;
                }
            }
            //end of taking prefrences in list
            Student s = new Student(name, age, fscMarks, ecatMarks, prefrences);
            Console.ReadKey();
            Console.Clear();
            return s;
        }
        public static void showStudents()
        {
            foreach(Student s in Student.students)
            {
                if(s.registeredProgram != null)
                {
                    Console.WriteLine("{0} has got Admission in {1}", s.name, s.registeredProgram.title);
                }
                else
                {
                    Console.WriteLine("{0} has not got admission", s.name);
                }
            }
        }
        public static void showRegisteredStudents()
        {
            Console.WriteLine("Name\t\tMerit\t\tDepartment");
            foreach(Student st in Student.students)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}", st.name, st.merit, st.registeredProgram.title);
            }
        }
        public static void showSpecificStudents(string title)
        {
            Console.WriteLine("Name\t\tMerit\t\tDepartment");
            foreach(var st in Student.students)
            {
                if(title == st.registeredProgram.title)
                {
                    Console.WriteLine("{0}\t\t{1}\t\t{2}", st.name, st.merit, st.registeredProgram.title);
                }
            }
        }
        public static void calculateFeeForAll()
        {
            foreach(var st in Student.students)
            {
                Console.WriteLine(st.name + "has" + st.calculateFee() + "fees");
            }
        }
    }
}
