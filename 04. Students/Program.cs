using System;
using System.Collections.Generic;

namespace _04._Students
{
    internal class Program
    {
        //Students
        //•	first name
        //•	last name
        //•	age
        //•	home town
        class Students
        {
                                  
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Age { get; set; }
            public string HomeTown { get; set; }
        }

        static void Main(string[] args)
        {
            List<Students> listStudents = new List<Students>();
            string comand=Console.ReadLine();
            while (comand!="end")
            {
                 string[] infoStudent=comand.Split(' ',StringSplitOptions.RemoveEmptyEntries);
                Students students = new Students();
                students.FirstName = infoStudent[0];
                students.LastName = infoStudent[1];
                students.Age=infoStudent[2];
                students.HomeTown = infoStudent[3];

                listStudents.Add(students);
                comand = Console.ReadLine();
            }
            string filter = Console.ReadLine();
            List<Students> filterStudent = new List<Students>();

            foreach (var stud in listStudents)
            {

                if (stud.HomeTown == filter)
                {
                    filterStudent.Add(stud);
                }

            }
            foreach (var student in filterStudent)
            {
                //"{firstName} {lastName} is {age} years old."
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }



        }
    }
}
