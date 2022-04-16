using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uni.BL;

namespace uni.UI
{
    class SubjectsUI
    {
        public static void viewSubjects(Student s)
        {
            if (s.registeredProgram != null)
            {
                Console.WriteLine("Subject_Code\t\tSubject_Type");
                foreach(var d in s.registeredProgram.subjects)
                {
                    Console.WriteLine("{0}\t\t\t{1}", d.subjectCode, d.subjectType);
                }
            }
            Console.ReadKey();
        }
        public static Subject takeInputForSubject()
        {
            string subjectCode, subjectType;
            int subjectCreditHours, subjectFee;
            Console.WriteLine("Enter Subject Code");
            subjectCode = Console.ReadLine();
            Console.WriteLine("Enter Subject Type");
            subjectType = Console.ReadLine();
            Console.WriteLine("Enter Subject Credit Hours");
            subjectCreditHours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Subject Fee");
            subjectFee = int.Parse(Console.ReadLine());
            Subject sub = new Subject(subjectCode, subjectType, subjectCreditHours, subjectFee);
            return sub;
        }
        public static List<Subject> RegisterSubjectsForStudent(Student st)
        {
            List<Subject> s = new List<Subject>();
            bool flag = false;
            Console.WriteLine("How many Subjects do You want to Register");
            int count = int.Parse(Console.ReadLine());
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter Subject Code");
                string code = Console.ReadLine();
                foreach(var temp in st.registeredProgram.subjects)
                {
                    if((code == temp.subjectCode && s.Contains(temp)) && Subject.getCreditHours(s) <20)
                    {
                        s.Add(temp);
                        flag = true;
                        break;
                    }
                }
                if(flag == false)
                {
                    Console.WriteLine("Enter Valid Subject.....");
                    i--;
                }
            }
            return s;
        }
    }
}
