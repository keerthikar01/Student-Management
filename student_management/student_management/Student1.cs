using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace student_management
{
    //created Student Class to get the student details
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }
        public string Department { get; set; }

        public DateTime CreatedDate { get; set; }
    }
    //Student details class to store the details in a list
    public class student_details
    {
        public List<Student> students = new List<Student>()
         {
             new Student(){ Id = 1, Name = "Chiki", Age = 21,Department= "ECE ", CreatedDate = DateTime.Now },
             new Student(){ Id = 2, Name = "Lala ", Age = 21,Department= "ECE ", CreatedDate = DateTime.Now },
             new Student(){ Id = 3, Name = "Jince", Age = 22,Department= "MECH", CreatedDate = DateTime.Now },
             new Student(){ Id = 4, Name = "Kala ", Age = 20,Department= "CSE ", CreatedDate = DateTime.Now },
             new Student(){ Id = 5, Name = "Boom ", Age = 19,Department= "ECE ", CreatedDate = DateTime.Now }


         };
        public Regex rgx = new Regex("[^A-Za-z0-9]");
        //Method created to display the student details
        public void disp()
        {
            Console.WriteLine("Student ID | Student Name | Student Age| Student Department | Created Date");
            foreach (var student in students)
            {
                Console.WriteLine("|         " + student.Id + "|" +student.Name + "         | " + student.Age + "         |                   " + student.Department + "|     " + student.CreatedDate.ToString("MM/dd/yyyy"));
              
            }
        }
    }
    //Created new_stu class to manage the student details(Edit,Add,Delete) and inherited the student_details class
    public partial class Manage_stu_details : student_details
    {
        public void add()
        {
            Console.WriteLine("Enter the Student Name");
            string new_Name = Console.ReadLine();
            Regex rgx = new Regex("[^A-Za-z0-9]");
            bool has = students.Any(o => o.Name == new_Name);
            Console.WriteLine(has);

            /*for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Name == new_Name)
                {
                    Console.WriteLine("Student Name already exists");

                }
            }*/
            if (has)
            {
                Console.WriteLine("Student Name already exists");

            }

           // else if (new_Name == null)
           else if(String.IsNullOrEmpty(new_Name))
            {
                Console.WriteLine("Name cannot be null");
            }
            

            else if (rgx.IsMatch(new_Name))
            {
                Console.WriteLine("Special Characters are not allowed to enter");
            }
            else
            {
                Console.WriteLine("Enter the age:");
                int age = int.Parse(Console.ReadLine());
                bool result = age.is_lesser();
                if (result)
                {
                    Console.WriteLine("Age should be greater than 18");
                }
                else
                {

                    int i = students.Count;

                    int j = 1 + i;
                    Console.WriteLine("Enter the Department");
                    string dpt = Console.ReadLine();
                    students.Add(new Student() { Id = j, Name = new_Name, Age = age, Department = dpt });
                }
            }

        }
        public void Edit()
        {
            Console.WriteLine("You want to Edit Name,Age or Dprt");
            string opt = Console.ReadLine();
            Console.WriteLine("Enter the ID to edit name:");
            int id = int.Parse(Console.ReadLine());
            if (opt == "Name")
            {

                Console.WriteLine("Enter the new name");
                String edited_name = Console.ReadLine();
                students[id].Name = edited_name;
            }
            else if (opt == "Age")
            {
                Console.WriteLine("Enter the New age");
                int edited_age = int.Parse(Console.ReadLine());
                bool result = edited_age.is_lesser();
                if(result)
                {
                    Console.WriteLine("Age should be greater than 18");
                }
                else
                {
                    //bool a = (edited_age => edited_age <= 18);
                    students[id].Age = edited_age;
                }
            }
            else if (opt == "Dprt")
            {

                Console.WriteLine("Enter the new Department");
                String edited_dprt = Console.ReadLine();
                students[id].Department = edited_dprt;
            }
        }
    }
    public partial class Manage_stu_details : student_details
    {
        public void Delete()
        {
            Console.WriteLine("Enter the Id to delete");
            int id = int.Parse(Console.ReadLine());
            /* students[id].Remove(id);
             students[id].Department.Remove(id);*/
            students.RemoveAt(id);
        }
    }

}
