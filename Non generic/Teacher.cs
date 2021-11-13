using System;
using System.Collections.Generic;
using System.Text;

namespace Non_generic
{
    class Teacher:Human
    {
        public Teacher(string name , string surname , string[] skills):base(name , surname)
        {
            Skills = skills;
        }

        public string[] Skills { get; set; }

    }
}
