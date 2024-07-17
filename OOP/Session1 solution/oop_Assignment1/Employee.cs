using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_Assignment1
{
	enum Gender
	{
		M = 1,
		F = 2,
		Male = 1,
		Female = 2
	}
    [Flags]
	enum SecurityLevel
	{
		guest =1 ,
		developer=2,
        secretary=4,
		DBA=8
    }
    internal class Employee
    {
        #region Attributes
        private int id = 0;
        private string name;
        private double salary;
        private Gender emp_gender;
        private SecurityLevel emp_security_level;
        private HiringDate? emp_hiring_date;
        #endregion

        public Employee(int id, string name, double salary, Gender gender, SecurityLevel securityLevel, HiringDate hiringDate)
        { 
            this.id = id;   
            Name = name;    
            Salary = salary;
            Emp_Gender = gender;
            Emp_Security_Level = securityLevel;
            Emp_Hiring_Date = hiringDate;
        }

        #region Properties
        public HiringDate Emp_Hiring_Date
        {
            get { return emp_hiring_date; }
            set { emp_hiring_date = value; }
        }
        public SecurityLevel Emp_Security_Level
        {
            get { return emp_security_level; }
            set { emp_security_level = value; }
        }
        public Gender Emp_Gender
        {
            get { return emp_gender; }
            set { emp_gender = value; }
        }
        public double Salary
        {
            get { return salary; }
            set
            {
                while (value <= 0)
                {
                    Console.WriteLine("Invalid Salary, Try again...");
                    double.TryParse(Console.ReadLine(), out value);
                }
                salary = value;
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                while (value == "" || value == null)
                {
                    Console.WriteLine("Invalid name, Try again...");
                    value = Console.ReadLine();
                }
                name = value;
            }
        }
        public int ID
        {
            get { return id; }
        }
        #endregion

        public override string ToString()
        {
            return $"ID: {ID} \nName: {Name} \nGender: {Emp_Gender} \nSecurityLevel: {Emp_Security_Level} \n" +
                   $"{string.Format("Salary: {0:C}", Salary)} \n{Emp_Hiring_Date.ToString()}";
        }

    }
}
