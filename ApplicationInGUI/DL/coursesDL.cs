using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ApplicationInGUI.BL;
using ApplicationInGUI.DL;

namespace ApplicationInGUI.DL
{
    class coursesDL
    {
        public static List<AdminBL> students = new List<AdminBL>();
            public static List<courseBL> courses = new List<courseBL>();
        public static  List<courseBL> registeredCourses = new List<courseBL>();

        public static void Addcourseintolist(courseBL b)
        {
            courses.Add(b);
        }
        public static void Addregisteredcourseintolist(courseBL b)
        {
                registeredCourses.Add(b);
        }
        public static void currentindex(int s)
        {
           courses.RemoveAt(s);
        }
        public static List<courseBL> returnlist2()
        {
            return courses;
        }
        public static void Writedataforcourses()

        {
            string path1 = "C:\\OPP\\GUI\\ApplicationInGUI\\courses.txt";

            StreamWriter myFile = new StreamWriter(path1, false);
            for (int index = 0; index < courses.Count; index++)
            {
                myFile.WriteLine(courses[index].getcoursename() + "," + courses[index].getcourseduration()+ "," + courses[index].getcoursecode() + ","+ courses[index].getfees());
            }
            myFile.Flush();
            myFile.Close();
        }
        public static void Writedataforregisteredcourses()

        {
            string path1 = "C:\\OPP\\GUI\\ApplicationInGUI\\registered courses.txt";

            StreamWriter myFile = new StreamWriter(path1, false);
            for (int index = 0; index < registeredCourses.Count; index++)
            {
                myFile.WriteLine(registeredCourses[index].getcoursename() + "," + registeredCourses[index].getcourseduration() + "," + registeredCourses[index].getcoursecode() + "," + registeredCourses[index].getfees());
            }
            myFile.Flush();
            myFile.Close();
        }

        public static bool readDataforcourse()

        {
            string path1 = "C:\\OPP\\GUI\\ApplicationInGUI\\courses.txt";
            if (File.Exists(path1))
            {
                StreamReader fileVariable = new StreamReader(path1);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string nameofsub = MuserDL.parseData(record, 1);
                    int duration = int.Parse(MuserDL.parseData(record, 2));
                    string code = MuserDL.parseData(record, 3);
                    float fee = float.Parse(MuserDL.parseData(record, 4));


                    courseBL b = new courseBL(nameofsub, duration, code,fee);
                   Addcourseintolist(b);
                }
                fileVariable.Close();
                return true;
            }
            return false;
        }

        public static bool readDataforregisteredcourses()

        {
            string path1 = "C:\\OPP\\GUI\\ApplicationInGUI\\registered courses.txt";
            if (File.Exists(path1))
            {
                StreamReader fileVariable = new StreamReader(path1);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string nameofsub = MuserDL.parseData(record, 1);
                    int duration = int.Parse(MuserDL.parseData(record, 2));
                    string code = MuserDL.parseData(record, 3);
                    float fee = float.Parse(MuserDL.parseData(record, 4));


                    courseBL b = new courseBL(nameofsub, duration, code, fee);
                    Addregisteredcourseintolist(b);
                }
                fileVariable.Close();
                return true;
            }
            return false;
        }
    }
}
