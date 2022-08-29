using System.Linq;
using System.Text.RegularExpressions;
namespace student_management
{//Main class
    public class program
    {
        public static void Main(String[] args)
        {

            Manage_stu_details ms = new Manage_stu_details();
            Manage_attendence ma = new Manage_attendence();
            Manage_marks m_s = new Manage_marks();
            Manage_course mc = new Manage_course();
            Stu_course sc = new Stu_course();
            Console.WriteLine("***Welcome to Student Management*** \n***Please Choose from the below option to proceed further***");
            Console.WriteLine("1.Student Details 2.Attendance 3.Marks 4.Course");
            string option = Console.ReadLine();
            string k;

            if (option == "Student Details")
            {
                do
                {
                    Console.WriteLine("Enter the Action: Add,Edit,Delete,Display");
                    string action = Console.ReadLine();

                    if (action == "Add")
                    {
                        ms.add();
                    }
                    else if (action == "Display")
                    {
                        ms.disp();
                    }
                    else if (action == "Edit")
                    {
                        ms.Edit();
                    }
                    else if (action == "Delete")
                    {
                        ms.Delete();
                    }
                    Console.WriteLine("Do you want to continue");
                    k = Console.ReadLine();

                } while (string.Equals(k, "yes", StringComparison.OrdinalIgnoreCase)
);
            }
            else if (string.Equals(option, "Attendance", StringComparison.OrdinalIgnoreCase))
            {
                do
                {
                    Console.WriteLine("Enter 1 to view full data, 2 to Add new data, 3 to view single data");
                    int i = int.Parse(Console.ReadLine());
                    switch (i)
                    {
                        case 1:
                            ma.Show_attendence();
                            break;
                        case 2:
                            ma.Add_new_data();
                            break;
                        case 3:
                            ma.Show_single_data();
                            break;
                    }
                    Console.WriteLine("Do you want to continue?");
                    k = Console.ReadLine();
                } while (string.Equals(k, "Yes", StringComparison.OrdinalIgnoreCase));

            }
            else if (string.Equals(option, "Marks", StringComparison.OrdinalIgnoreCase))
            {
                do
                {
                    Console.WriteLine("Enter 1 to view the Marks 2 to Edit Marks 3 to Add new 4 to Get particular students mark");
                    int i = int.Parse(Console.ReadLine());
                

                    switch (i)
                    {
                        case 1:
                            m_s.Show_marks();
                            break;
                        case 2:
                            m_s.Edit_marks();
                            break;
                        case 3:
                            m_s.Add_new_marks();
                            break;
                        case 4:
                            m_s.Display_1_mark();
                            break;
                    }
                    Console.WriteLine("Do you want to continue?");
                    k = Console.ReadLine();
                } while (k == "yes"); 
            }
            else if(string.Equals(option, "Course", StringComparison.OrdinalIgnoreCase))
            {
                do
                {
                    Console.WriteLine("Enter 1 to display the available course \n2 to Add new course \n3 to get the list of students joined the particular course ");
                    int i = int.Parse(Console.ReadLine());
                    switch (i)
                    {
                        case 1:
                            mc.Show_Course();
                            break;
                        case 2:
                            mc.Add_new_course();
                            break;
                        case 3:
                            sc.DisplayStu_list();
                            break;

                    }
                    Console.WriteLine("Do you want to continue?");
                    k = Console.ReadLine();
                } while (string.Equals(k, "Yes", StringComparison.OrdinalIgnoreCase));
            }


        }
    }
}