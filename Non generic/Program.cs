using System;
using System.Collections;
using System.Collections.Generic;

namespace Non_generic
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student("Elnur", "Huseynov");
            Student student2 = new Student("Ali", "Huseynov");
            Student student3 = new Student("Eyyub", "Huseynov");
            Student student4 = new Student("Akif", "Huseynov");
            Student student5 = new Student("MMMM", "Huseynov");

            string[] skills = { "C#", "Javascript" };
            Teacher teacher1 = new Teacher("Agil", "Bashirov", skills);
            Teacher teacher2 = new Teacher("Elchin", "Aghayev", skills);



            ArrayList arrayList = new ArrayList();
            arrayList.Add(student1);
            arrayList.Add(student2);
            arrayList.Add(student3);
            arrayList.Add(student4);
            arrayList.Add(student5);

            foreach (var item in Extetion<Student>.GetType(arrayList))
            {
                Console.WriteLine(item);
            }


        }

        public static List<Student> GetStudents(ArrayList list)
        {
            List<Student> newList = new List<Student>();

            foreach (var item in list)
            {
                if (item is Student)
                {
                    newList.Add((Student)item);
                }
                
            }
            return newList;
        }
    }
}
