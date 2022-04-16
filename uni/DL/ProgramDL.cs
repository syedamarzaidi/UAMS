using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uni.BL;
namespace uni.DL
{
    class ProgramDL
    {
        public static void addDegreeToList(DegreeProgram d)
        {
            //This function is adding a degree to programSubject list of DegreeProgram type
            DegreeProgram.programSubjects.Add(d);
        }
    }
}
