using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationInGUI.DL;
using ApplicationInGUI;

namespace ApplicationInGUI.BL
{
   public class AdminBL:Muser
    {
        private string namesforadmin;
        private float ecatmarksforadmin;
        private float marksforadmin;
        private float percentageforadmin;
        private int rollnoforadmin;
        public int Rollnoforadmin { get => rollnoforadmin; set => rollnoforadmin = value; }
        public string Namesforadmin { get => namesforadmin; set => namesforadmin = value; }
        public float Marksforadmin { get => marksforadmin; set => marksforadmin = value; }
        public float Ecatmarksforadmin { get => ecatmarksforadmin; set => ecatmarksforadmin = value; }
        public float Percentageforadmin { get => percentageforadmin; set => percentageforadmin = value; }

        internal AdminDL AdminDL
        {
            get => default;
            set
            {
            }
        }

        internal AdminDL AdminDL1
        {
            get => default;
            set
            {
            }
        }

        internal coursesDL coursesDL
        {
            get => default;
            set
            {
            }
        }

        public AdminBL()
        {

        }
        

        public AdminBL(string name, string password, string role) : base(name, password, role)
        {

        }

        public AdminBL(string namesforadmin, float ecatmarksforadmin, float marksforadmin, float percentageforadmin, int rollnoforadmin, string name, string password) : base(name, password)
        {
            this.namesforadmin = namesforadmin;
            this.ecatmarksforadmin = ecatmarksforadmin;
            this.marksforadmin = marksforadmin;
            this.percentageforadmin = percentageforadmin;
            this.rollnoforadmin = rollnoforadmin;
        }
       public AdminBL(string namesforadmin, float ecatmarksforadmin, float marksforadmin, int rollnoforadmin)
        {
            this.namesforadmin = namesforadmin;
            this.ecatmarksforadmin = ecatmarksforadmin;
            this.marksforadmin = marksforadmin;
            this.rollnoforadmin = rollnoforadmin;

        }
        public AdminBL(string namesforadmin, float ecatmarksforadmin, float marksforadmin, int rollnoforadmin, float percentageforadmin)
        {
            this.namesforadmin = namesforadmin;
            this.ecatmarksforadmin = ecatmarksforadmin;
            this.marksforadmin = marksforadmin;
            this.rollnoforadmin = rollnoforadmin;
            this.percentageforadmin = percentageforadmin;

        }

        public void setnamesforadmin(string namesforadmin)
        {
            this.namesforadmin = namesforadmin;
        }
        public string getnamesforadmin()
        {
            return namesforadmin;
        }
        public void setecatmarks(float ecatmarksforadmin)
        {
            this.ecatmarksforadmin = ecatmarksforadmin;
        }
        public float getecatmarks()
        {
            return ecatmarksforadmin;
        }
        public float getmarksforadmin()
        {
            return marksforadmin;
        }
        public void setgetmarks(float marksforadmin)
        {
            this.marksforadmin = marksforadmin;
        }
        public void setrollnumber(int rollnoforadmin)
        {
            this.rollnoforadmin = rollnoforadmin;
        }
        public int getrollno()
        {
            return rollnoforadmin;
        }
        public void setpercentage(float percentageforadmin)
        {
            this.percentageforadmin = percentageforadmin;
        }
        public float getpercentage()
        {
            return percentageforadmin;
        }
      
        public static int Roolindex(int rool1, List<AdminBL> students)
        {
            int index = -1;
            for (int i = 0; i < students.Count; i++)
            {
                if (rool1 == students[i].rollnoforadmin)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public static bool IsPresentForStudents(int roolname, List<AdminBL> students)
        {
            for (int index = 0; index < students.Count; index++)
            {
                if (students[index].rollnoforadmin == roolname)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool IsPresent(int rollname)
        {
            for (int index = 0; index < AdminDL.students.Count; index++)
            {
                if (AdminDL.students[index].rollnoforadmin == rollname)
                {
                    return true;
                }
            }
            return false;
        }
        public static List<AdminBL> searchstudent(string s)
        {
            List<AdminBL> se = AdminDL.students.FindAll(item => item.getnamesforadmin().StartsWith(s));
            return se;
        }
    }


}
    

