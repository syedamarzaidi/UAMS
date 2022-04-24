using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uni.BL
{
    class Student
    {
        public Student()
        {

        }
        public Student(string name, int age, float fscMarks, float ecatMarks, List<DegreeProgram> prefrences)
        {
            this.name = name;
            this.age = age;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks; 
            this.prefrences = prefrences;
        }
        public string name;
        public int age;
        public float fscMarks;
        public float ecatMarks;
        public float merit;
        public List<Subject> studentSubjects = new List<Subject>();
        public List<DegreeProgram> prefrences = new List<DegreeProgram>();
        public DegreeProgram registeredProgram =  new DegreeProgram(); // This is to store registered subject by user
        public static List<Student> students = new List<Student>();
        public void calculateMerit()
        {
            this.merit = (((this.fscMarks / 1100) * 100f) * 0.45f) + (((this.ecatMarks/400)*100f)*0.65f);
        }
        public static Student isStudentExits(string name)
        {
            foreach(var st in students)
            {
                if(name == st.name)
                {
                    return st;
                }
            }
            return null;
        }
        public float calculateFee()
        {
            int f = 0;
            foreach(var fee in studentSubjects)
            {
                f = f + fee.subjectFee;
            }
            return f;
        }
    }
    
}
