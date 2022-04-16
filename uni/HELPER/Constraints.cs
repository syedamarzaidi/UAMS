using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uni.BL;

namespace uni.HELPER
{
    class Constraints
    {
        public static bool isProgramsListEmpty(List<DegreeProgram> d)
        {
            if(d.Count > 0)
            {
                return false;
            }
            return true;
        }
    }
}
