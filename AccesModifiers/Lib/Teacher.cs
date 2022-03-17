using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    public class Teacher:Person
    {
        public Teacher()
        {
            Name = "Zulfiyye";
        }

        public void telebe()
        {
            Person ad = new Person();
            string soyad = ad.Name;
        }
    }
}
