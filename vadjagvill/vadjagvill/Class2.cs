using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vadjagvill
{
    class Class2
    {
        int age;
        string fname, lname, adress;
        bool student;

        public void SetValues2(string var1, string var2, int var3, bool var4, string var5)
        {
            fname = var1;
            lname = var2;
            age = var3;
            student = var4;
            adress = var5;
        }

        public string GetFname()
        {
            return fname;
        }

        public string GetLname()
        {
            return lname;
        }

        public int GetAge()
        {
            return age;
        }

        public string GetStudent()
        {
            if(student == true)
            {
                return "Student";
            }
            else
            {
                return "Inte student";
            }
        }

        public string GetAdress()
        {
            return adress;
        }
    }
}
