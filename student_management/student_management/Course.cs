using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_management
{
    //class to get the course Properties
    public class Course
    {
        public string Course_name { get; set; }
        public String Course_id { get; set; }
    }
    //class to store the course details and display them
    public class Course_details
    {
        public List<Course> Course_list = new List<Course>()
        {
            new Course(){ Course_id ="ECE",Course_name ="BE-Electronics And Communication Engineering" },
            new Course(){ Course_id ="CSE",Course_name ="BE-Computer Science Engineering" },
            new Course(){ Course_id ="EEE",Course_name ="BE-Electrical And Electronics Engineering" },
            new Course(){ Course_id ="MECH",Course_name ="BE-Mechanical Engineering" }

        };

        public void Show_Course()
        {
            foreach (var course in Course_list)
            {
                Console.WriteLine("Course ID:"+course.Course_id+" Course Name:"+course.Course_name);
            }
        }
    }
    //class to manage the course deatils
    public class Manage_course : Course_details
    {
        public void Add_new_course()
        {
            Console.WriteLine("Enter the New Course ID");
            string new_id = Console.ReadLine();
            Console.WriteLine("Enter the Course Name");
            string new_course = Console.ReadLine();
            Course_list.Add(new Course { Course_id = new_id, Course_name = new_course });
        }
       
        
    }
    //class to Filter the sudents based on the course
    public class Stu_course : student_details
    {
        public void DisplayStu_list()
        {
            Console.WriteLine("Enter the Course ID to get the Student List");
            string course = Console.ReadLine();
            Console.WriteLine("Students Joined under the " + course + " are:");
            for (int i = 0; i < students.Count; i++)
            {
                if (course == students[i].Department)
                {
                    Console.WriteLine(students[i].Name);
                }
            }
        }
    }
    
}

