namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome User !");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------");

            Employee emp1 = new Employee();
            Employee emp2 = new Employee();

            Console.WriteLine("Please fill the first employee's data ");
            
            Console.Write("Enter the ID : ");
            emp1.Id = int.Parse(Console.ReadLine());

            Console.Write("Enter the name : ");
            emp1.Name = Console.ReadLine();

            Console.Write("Enter the title : ");
            emp1.Title = Console.ReadLine();

            Console.Write("Enter The Age : ");
            emp1.Age = int.Parse(Console.ReadLine());

            Console.Write("Enter the Date of birth : ");
            emp1.DateofBirth = DateOnly.Parse(Console.ReadLine());

            Console.Write("Enter the hire date : ");
            emp1.Hiredate = DateOnly.Parse(Console.ReadLine());

            Console.Write("Enter the Email : ");
            emp1.Email = Console.ReadLine();

            Console.Write("Enter the PhoneNumber : ");
            emp1.Phone = Console.ReadLine();

            Console.Write("Enter the Salary : ");
            emp1.Salary = int.Parse(Console.ReadLine());

            Console.WriteLine("Now This is what you filled : ");
            Console.WriteLine();

            emp1.printEmployee();

            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("We filled second employee data for you ");

            emp2.Id = 2;
            emp2.Name = "Sarah Ahmed";
            emp2.Age = 20;
            emp2.Title = "Data Analyst";
            emp2.Email = "Sara@Gmail.com";
            emp2.Phone = "01100221277";
            emp2.DateofBirth = DateOnly.Parse("7/7/2004")  ;
            emp2.Hiredate = DateOnly.Parse("1/1/2025");
            emp2.Salary = 200000;
            
            
            Console.WriteLine("Now This is what we filled : ");
            Console.WriteLine();
            
            emp2.printEmployee();

            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------");




        }
    }

    public class Employee
    {
        private int _id;
        private string _name;
        private int _age;
        private string _title;
        private DateOnly _hiredate;
        private DateOnly _dateofbirth;
        private string _email;
        private string _phone;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public DateOnly Hiredate
        {
            get { return _hiredate; }
            set { _hiredate = value; }
        }

        public DateOnly DateofBirth
        {
            get { return _dateofbirth; }
            set { _dateofbirth = value; }

        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set{ _phone = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }

        }

        public double Salary { get; set; }


        public void printEmployee()
        {
            Console.WriteLine($"Employee ID : {Id} , And his/her name is {Name} , the age is {Age} , the title is {Title} , the hiredate is {Hiredate} , while the date of birth is {DateofBirth} , Email : {Email} , Phone Number : {Phone} , And the most important the salary is {Salary}");
        }

    }
    }
