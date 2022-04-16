using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uni.BL
{
    class DegreeProgram
    {
        public DegreeProgram()
        {

        }
        public DegreeProgram(string title,string duration,int seats,List<Subject> subjects)
        {
            this.title = title;
            this.duration = duration;
            this.seats = seats;
            this.subjects = subjects;
            this.bookedSeats = 0;
        }
        public string title;
        public string duration;
        public int seats;
        public int bookedSeats;
        public Subject sub = new Subject();
        public List<Subject> subjects = new List<Subject>();
        public static List<DegreeProgram> programSubjects = new List<DegreeProgram>();
    }
}
