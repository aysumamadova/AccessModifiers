using System;
using System.Collections.Generic;
using System.Text;
using Lib;

namespace AccesModifiers.Models
{
    class Student:Person
    {
        public Student()
        {
            Name = "Aysu";
        }

        public void Stud()
        {
            Person ad = new Person();
            ad.Name = "Ayse";

        }
    }
}
