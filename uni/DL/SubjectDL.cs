using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uni.UI;
using uni.BL;

namespace uni.DL
{
    class SubjectDL
    {
        public static void RegisterSubjects(Student s)
        {
            List<Subject> sub = SubjectsUI.RegisterSubjectsForStudent(s);
            s.studentSubjects = sub;
        }
    }
}
