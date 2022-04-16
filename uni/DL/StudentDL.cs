using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uni.BL;
namespace uni.DL
{
    class StudentDL
    {
        public static void addStudentToList(Student s) 
        {
            //This Function is adding student object in students list
            Student.students.Add(s);
        }
        public static List<Student> sortStudents()
        {
            List<Student> sortedStudentsList = new List<Student>();
            calculateAllStudentsMerit();
            sortedStudentsList = Student.students.OrderByDescending(o => o.merit).ToList();
            return sortedStudentsList; 
        }
        public static void calculateAllStudentsMerit()
        {
            //This Function is Calculating merit for all students
            foreach(var st in Student.students)
            {
                st.calculateMerit();
            }
        }
        public static void giveAddmission(List<Student> sortedStudentsList)
        {
            foreach(var st in sortedStudentsList)
            {
                foreach(var d in st.prefrences)
                {
                    if(d.bookedSeats > 0 && st.registeredProgram == null)
                    {
                        st.registeredProgram = d;
                        d.seats--;
                        break;
                    }
                }
            }
        }
    }
}
