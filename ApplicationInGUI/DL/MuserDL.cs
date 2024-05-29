using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ApplicationInGUI.BL;

namespace ApplicationInGUI.DL
{
    class MuserDL
    {
        private static List<Muser> userlist = new List<Muser>();

        public static void adduserintolist(Muser user)
        {
            userlist.Add(user);
        }
        public static Muser signIn(Muser user)
        {
            foreach (Muser storeUser in userlist)
            {

                if (storeUser.getusername() == user.getusername() && storeUser.getpassword() == user.getpassword())
                    return storeUser;

            }
            return null;
        }
        public static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length;
            x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        public static bool readData(string path)

        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string name = parseData(record, 1);
                    string password = parseData(record, 2);
                    string role = parseData(record, 3);
                    Muser user = new Muser(name, password, role);
                    adduserintolist(user);
                }
                fileVariable.Close();
                return true;
            }
            return false;
        }
        public static void storeDataInFile(string path, Muser user)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(user.getusername() + "," + user.getpassword() + "," + user.getrole());
            file.Flush();
            file.Close();
        }
    }
}
