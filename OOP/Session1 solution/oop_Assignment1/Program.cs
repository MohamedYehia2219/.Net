using System.Xml.Linq;

namespace oop_Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1 Q1
            //Console.WriteLine($"Distance = {calcDistance()}");
            #endregion

            #region Part 1 Q2
            //Console.WriteLine($"The oldest one is: {getOldestPerson()} ");
            #endregion

            #region Part 2
            /*Employee[] employees;
            employees = EmployessData();
            Console.Clear();
            dispalyEmployyesdata(employees);
            Console.WriteLine("employees after Hirring Date sorting: ");
            employees = sortEmployess(employees);
            dispalyEmployyesdata(employees);*/
            #endregion
        }
        static double calcDistance()
        {
            float value;
            Point p1 = new Point();
            Point p2 = new Point();

            Console.Write("Enter x of point 1: ");
            float.TryParse(Console.ReadLine(), out value);
            p1.X = value;
            Console.Write("Enter y of point 1: ");
            float.TryParse(Console.ReadLine(), out value);
            p1.Y = value;

            Console.Write("Enter x of point 2: ");
            float.TryParse(Console.ReadLine(), out value);
            p2.X = value;
            Console.Write("Enter y of point 2: ");
            float.TryParse(Console.ReadLine(), out value);
            p2.Y = value;

            return p1.calcDistance(p2);
        }
        static string getOldestPerson()
        {
            Person[] persons = new Person[3];
            int age, max=0, index=0;
            for (int i = 0; i < persons.Length; i++)
            {
                Console.Write($"Enter Name of person {i+1}: ");
                persons[i].Name = Console.ReadLine();
                do
                {
                    Console.Write($"Enter Age of person {i+1}: ");
                    int.TryParse(Console.ReadLine(), out age);
                } while (age <= 0 || age > 100);
                persons[i].Age = age;
                if (persons[i].Age > max)
                {
                    max = persons[i].Age;
                    index = i;
                }
            }
            return persons[index].Name;
        }
        static Employee[] EmployessData()
        {
            Employee[] employees = new Employee[3];
            string name;
            double salary;
            object gender,security;
            int day, month, year;
            bool valid;
            HiringDate hiringDate;
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"Enter Details of Employee {i + 1}: ");
                Console.WriteLine($"Enter Name of Employee {i + 1}: ");
                name = Console.ReadLine();
                Console.WriteLine($"Enter Salary of Employee {i + 1}: ");
                double.TryParse(Console.ReadLine(), out salary);
                do
                {
                    Console.WriteLine($"Enter Gender of Employee {i + 1}: ");
                    valid = Enum.TryParse(typeof(Gender), Console.ReadLine(), true, out gender);
                } while (!(valid && Enum.IsDefined(typeof(Gender), gender)));
                do
                {
                    Console.WriteLine($"Enter Security Level of Employee {i + 1}: ");
                    valid = Enum.TryParse(typeof(SecurityLevel), Console.ReadLine(), true, out security);
                } while (!(valid && Enum.IsDefined(typeof(SecurityLevel), security)));
                Console.WriteLine($"Enter Day of Hiring Date of Employee {i + 1}: ");
                int.TryParse(Console.ReadLine(), out day);
                Console.WriteLine($"Enter Month of Hiring Date of Employee {i + 1}: ");
                int.TryParse(Console.ReadLine(), out month);
                Console.WriteLine($"Enter Year of Hiring Date of Employee {i + 1}: ");
                int.TryParse(Console.ReadLine(), out year);
                hiringDate = new HiringDate(day, month, year);
                employees[i] = new Employee(i+1,name,salary,(Gender)gender,(SecurityLevel)security,hiringDate);
                Console.WriteLine("===========================================================");
            }
            return employees;
        }
        static void dispalyEmployyesdata(Employee[] employees)
        {
            for (int i = 0; i < employees?.Length; i++)
            {
                Console.WriteLine($"Employee {i + 1} Data: ");
                Console.WriteLine(employees[i]?.ToString());
                Console.WriteLine($"===========================================================");
            }
        }
        static Employee[] sortEmployess(Employee[] employees)
        {
            Employee temp;
            for (int i = 0; i < employees.Length - 1; i++)
            {
                for (int j = i + 1; j < employees.Length; j++)
                {
                    if (employees[i].Emp_Hiring_Date.Year < employees[j].Emp_Hiring_Date.Year ||
                        (employees[i].Emp_Hiring_Date.Year == employees[j].Emp_Hiring_Date.Year &&
                        employees[i].Emp_Hiring_Date.Month < employees[j].Emp_Hiring_Date.Month) ||
                        (employees[i].Emp_Hiring_Date.Year == employees[j].Emp_Hiring_Date.Year &&
                        employees[i].Emp_Hiring_Date.Month == employees[j].Emp_Hiring_Date.Month &&
                        employees[i].Emp_Hiring_Date.Day < employees[j].Emp_Hiring_Date.Day))
                    { 
                        temp = employees[i];
                        employees[i] = employees[j];
                        employees[j] = temp;
                    }
                }
            }
            return employees;
        }
    }// calss
}// namespace
