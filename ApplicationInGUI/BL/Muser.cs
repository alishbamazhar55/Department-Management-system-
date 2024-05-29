using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationInGUI.BL;

namespace ApplicationInGUI.BL
{
   public class Muser
    {
        private string userName;
        private string userpassword;
        private string role;

        public Muser()
        {

        }

        public Muser(string userName, string userpassword, string role)
        {
            this.userName = userName;
            this.userpassword = userpassword;
            this.role = role;
        }
        public Muser(string userName, string userpassword)
        {
            this.userName = userName;
            this.userpassword = userpassword;
            this.role = "Alishba";
        }

        internal DL.MuserDL MuserDL
        {
            get => default;
            set
            {
            }
        }

        internal DL.MuserDL MuserDL1
        {
            get => default;
            set
            {
            }
        }

        public string getusername()
        {
            return userName;
        }
        public string getpassword()
        {
            return userpassword;
        }
        public string getrole()
        {
            return role;
        }
        public bool isadmin()
        {
            if (role == "Admin"|| role=="admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
            public bool isadmin2()
            {
                if (role == "Student"|| role=="student")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }

