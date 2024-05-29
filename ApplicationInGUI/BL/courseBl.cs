using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationInGUI.BL
{
    class courseBL
    {
        private string coursename;
        private int duration;
        private string coursecode;
        private float fees;

        public string Coursename { get => coursename; set => coursename = value; }
        public int Duration { get => duration; set => duration = value; }
        public string Coursecode { get => coursecode; set => coursecode = value; }
        public float Fees { get => fees; set => fees = value; }

        internal DL.coursesDL coursesDL
        {
            get => default;
            set
            {
            }
        }

        public courseBL(string coursename, int duration, string coursecode,float fees)
        {
            this.coursename = coursename;
            this.duration = duration;
            this.coursecode = coursecode;
            this.fees = fees;
          
         

        }
        public courseBL(string coursecode)
        {
            this.coursecode = coursecode;

        }
        

        public void setcoursecode(string coursecode)
        {
            this.coursecode = coursecode;
        }
        public string getcoursecode()
        {
            return coursecode;
        }
        public void setcourseduration(int duration)
        {
            this.duration = duration;
        }
        public int getcourseduration()
        {
            return duration;
        }
        public string getcoursename()
        {
            return coursename;
        }
        public void setcoursename(string coursename)
        {
            this.coursename = coursename;
        }
        public void setfees(float fees)
        {
            this.fees = fees;
        }
        public float getfees()
        {
            return fees;
        }

        public static int codeindex(string code, List<courseBL> courses)
        {
            int index = -1;
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].coursecode == code)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public static bool Checkcode(string code, List<courseBL> courses)
        {

            for (int index = 0; index < courses.Count; index++)
            {
                if (courses[index].getcoursecode() == code)
                {
                    return true;
                }

            }
            return false;
        }
        public static string checkcodeID()
        {
            Console.WriteLine("enter course code: ");
            string code = Console.ReadLine();
            return code;
        }
    }
}
