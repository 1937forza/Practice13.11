using System;
using System.Collections.Generic;
using System.Text;

namespace Non_generic
{
    class Human
    {
        public Human(string name , string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public override string ToString()
        {
            return $"{Name}  {Surname}";
        }

    }
}
