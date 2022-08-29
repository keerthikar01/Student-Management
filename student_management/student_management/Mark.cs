using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_management
{
    //class which gets the mark properties
    public class Mark
    {
        public int Stu_id { get; set; }
        public string Subject_code { get; set; }
        public string Sem { get; set; }
        public int mark_scored { get; set; }
    }
    // Class which stores the mark details and displays the details
    public class Mark_details
    {
        public List<Mark> marks = new List<Mark>()
        {
            new Mark(){Stu_id=1,Sem = "1", Subject_code = "ECE1" , mark_scored = 89},
            new Mark(){Stu_id=1,Sem = "1", Subject_code = "ECE6" , mark_scored = 67},
            new Mark(){Stu_id=2,Sem = "2", Subject_code = "CSE1" , mark_scored = 92},
            new Mark(){Stu_id=2,Sem = "2", Subject_code = "CSE4" , mark_scored = 90},
            new Mark(){Stu_id=3,Sem = "3", Subject_code = "MECH1" , mark_scored = 79},
            new Mark(){Stu_id=3,Sem = "3", Subject_code = "MECH6" , mark_scored = 80}

        };
        public void Show_marks()
        {
            foreach(var mark in marks)
            {
                Console.WriteLine("Student Id:"+mark.Stu_id+" Sem:"+mark.Sem+" Sub Code:"+mark.Subject_code+" Marks Scored:"+mark.mark_scored);
            }
        }
    }
    //class whsich manages the mark deatails
    public class Manage_marks : Mark_details
    {
        public void Add_new_marks()
        {
            Console.WriteLine("Enter the Student Id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Sem");
            string sem = Console.ReadLine();
            Console.WriteLine("Enter the Subject code");
            string subject = Console.ReadLine();
            Console.WriteLine("Enter the marks scored");
            int mark = int.Parse(Console.ReadLine());
            marks.Add(new Mark() { Stu_id = id, Sem = sem, Subject_code = subject, mark_scored = mark });

        }
        public void Edit_marks()
        {
            Console.WriteLine("Choose from the below option \n1.sem 2.subject 3.marks");
            int act =int.Parse( Console.ReadLine());
            Console.WriteLine("Enter the id to edit");
            int id = int.Parse(Console.ReadLine());
            switch (act)
            {
                case 1:
                    Console.WriteLine("Enter the New sem");
                    string new_sem = Console.ReadLine();
                    marks[id].Sem = new_sem;
                    break;
                case 2:
                    Console.WriteLine("Enter the New Subject code");
                    string new_sub = Console.ReadLine();
                    marks[id].Subject_code = new_sub;
                    break;
                case 3:
                    Console.WriteLine("Enter the New Marks");
                    int new_mark = int.Parse(Console.ReadLine());
                    marks[id].mark_scored= new_mark;
                    break;
            }
        }
        public void Display_1_mark()
        {
            Console.WriteLine("Enter the Student ID to get the Mark List");
            int mark1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Student Id | Marks");
            for (int i = 0; i < marks.Count; i++)
            {
                if (mark1 == marks[i].Stu_id)
                {
                    Console.WriteLine(marks[i].Stu_id + "          |" + marks[i].mark_scored);
                }
            }
        }
    }

   
}

