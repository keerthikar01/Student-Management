using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_management
{
    //class to get the Attendence properties
    public class Attendence
    {
        public int Stu_id { get; set; }
        public string Month { get; set; }
        public int No_of_days { get; set; }
        public int No_of_days_present { get; set; }
    }
    //class to store the attendence data
    public class Attendence_data
    {
        public List<Attendence> Attendence_list = new List<Attendence>()
        {
            new Attendence() { Stu_id = 1, Month = "Jun", No_of_days = 22, No_of_days_present = 20 },
            new Attendence() { Stu_id = 2, Month = "Jun", No_of_days = 21, No_of_days_present = 18 },
            new Attendence() { Stu_id = 3, Month = "Jun", No_of_days = 23, No_of_days_present = 20 },
            new Attendence() { Stu_id = 4, Month = "Jun", No_of_days = 21, No_of_days_present = 21 },
            new Attendence() { Stu_id = 5, Month = "Jun", No_of_days = 22, No_of_days_present = 22 }

        };
    // Method to display the Attendence List
        public void Show_attendence()
        {
            Console.WriteLine("|Student ID | Month | Working Days | Total Days Present");
            Console.WriteLine("_______________________________________________________");
            foreach(var attendence in Attendence_list)
            {
                Console.WriteLine("|"+ attendence.Stu_id+"          |    "+attendence.Month+"|            "+attendence.No_of_days+"| "+attendence.No_of_days_present);
            }
        }
    }
    //Class to manage the attendence details(Add,Edit,fetch single user data)
    public class Manage_attendence :Attendence_data
    {
        public void Add_new_data()
        {
            Console.WriteLine("Enter the Student Id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Select the Month - Jan,Feb,Mar,Apr,May,Jun,Jul,Aug,Sep,Otc,Nov,Dec");
            string month = Console.ReadLine();
            Console.WriteLine("Enter the No.of Working Days in the Chosen Month");
            int Working_days = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the No.of Days Present");
            int present_days = int.Parse(Console.ReadLine());
            Attendence_list.Add(new Attendence() { Stu_id = id, Month = month, No_of_days = Working_days, No_of_days_present = present_days });
        }
        public void Show_single_data()
        {
            Console.WriteLine("Enter the Student Id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Month:" + Attendence_list[id].Month + " Working Days:" + Attendence_list[id].No_of_days + " Total Days Present:" + Attendence_list[id].No_of_days_present);
        }
    }
}
