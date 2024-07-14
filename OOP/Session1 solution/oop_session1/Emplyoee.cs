using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_session1
{
    internal struct Emplyoee
    {
        private int id;
        private string name;
        private double salary;

        /*public Emplyoee(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }*/
        public Emplyoee(int id, string name, double salary)
        {
            this.id = id;
            // use properties for initialization as the vaidation
            Name = name;
            Salary = salary;
        }

        #region getters and setters
        public int getId() { return id; }   // make id read only attribute --> has get only 
        public void setName(string name)    //validate data 
        {
            if (name != "")
                this.name = name ?? this.name;
        }
        public string getName() { return name; }
        public void setSalary(double salary)
        {
            if (salary > 0)
                this.salary = salary;
        }
        public double getSalary() { return salary; }
        #endregion

        // properties --> [full, automatic, special (Indexer)]
        // in IL, each property is converted to function includes setter and getter functions.  

        #region Full property
        // we can write simple logic inside it
        public string Name
        {
            set
            {
                if (value != "")
                    name = value;
            }
            get { return this.name; }
            //init{}
        }
        public int Id       // read only
        {
            get { return id; }
        }
        public double Salary
        {
            get { return salary; }
            set
            {
                if (value > 0)
                    salary = value;
            }
        }
        #endregion

        #region Automatic property
        // [it creates the attribute of the property and initialize it with its default value] with out displaying
        // can't write logic inside it
        public string Address { get; set; }
        public int Age { get; set; }
        #endregion

        public override string ToString()
        {
            return $"id: {id}   name: {name}    salary:{salary}";
        }
    }
}
