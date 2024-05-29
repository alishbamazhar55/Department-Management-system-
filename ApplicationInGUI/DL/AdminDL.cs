using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationInGUI.BL;
using System.IO;
using ApplicationInGUI;
using ApplicationInGUI.BL;

namespace ApplicationInGUI.DL
{
    class AdminDL
    {
        public static List<AdminBL> students = new List<AdminBL>();
        
        internal static List<AdminBL> Students { get => students; set => students = value; }

        public static void storeDataInListforadmin( AdminBL persons)
        {
            Students.Add(persons);
        }
        public static List<AdminBL> returnlist()
        {
            return students;
        }
        public static void currentindex(int s)
        {
            students.RemoveAt(s);
        }
       

        public static void Writedataforadnmin()

        {
            string path1 = "C:\\OPP\\GUI\\ApplicationInGUI\\AdminData.txt";

            StreamWriter myFile = new StreamWriter(path1, false);
            for (int index = 0; index < students.Count; index++)
            {
                myFile.WriteLine(students[index].getrollno() + "," + students[index].getnamesforadmin() + "," + students[index].getmarksforadmin() + "," + students[index].getecatmarks() + "," + students[index].getpercentage());
            }
            myFile.Flush();
            myFile.Close();
        }


        public static bool readDataforadmin()

        {
            string path1 = "C:\\OPP\\GUI\\ApplicationInGUI\\AdminData.txt";
            if (File.Exists(path1))
            {
                students.Clear();
                StreamReader fileVariable = new StreamReader(path1);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {

                    int rollno = int.Parse(MuserDL.parseData(record, 1));
                    string nameforadmin = MuserDL.parseData(record, 2);
           
                    float fscmarks = float.Parse(MuserDL.parseData(record, 3));
                    float ecatmarks = float.Parse(MuserDL.parseData(record, 4));
                    float percentage = float.Parse(MuserDL.parseData(record, 5));
                    AdminBL ad = new AdminBL(nameforadmin, fscmarks, ecatmarks, rollno, percentage);
                    storeDataInListforadmin( ad);
                  

                }
                fileVariable.Close();
                return true;
            }
            return false;
        }
    }
}
