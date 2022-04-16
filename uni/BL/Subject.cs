using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uni.BL
{
    class Subject
    {
        public Subject()
        {

        }
        public Subject(string subjectCode,string subjectType,int subjectCreditHours,int subjectFee)
        {
            this.subjectCode = subjectCode;
            this.subjectType = subjectType;
            this.subjectCreditHours = subjectCreditHours;
            this.subjectFee = subjectFee;
        }
        public string subjectCode;
        public string subjectType;
        public int subjectCreditHours;
        public int subjectFee;
        public static int getCreditHours(List<Subject> s)
        {
            int Count = 0;
            if(s != null)
            {
                foreach(var su in s)
                {
                    Count = Count + su.subjectCreditHours;
                }
            }
            return Count;
        }
    }
}
