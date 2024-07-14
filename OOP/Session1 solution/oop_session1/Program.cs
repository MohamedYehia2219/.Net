namespace oop_session1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct
            /* // struct is user [value data type] like enum
             point p1;   // declare [object] from type point in [stack]
                         // p1 in not reference [p1 is not null]
                         // CLR allocate 8 (4 for each int parameter) un initialized bytes in stack
             p1 = new point();
             // new --> just for constructor selection
             // constructor --> special method has no return type
             //             --> named as class or struct name
             //             --> used for initialize [struct] members [not class]
             //             --> CLR create default parameterless constructor that initialize parameters with the default values
             Console.WriteLine(p1);             //default: path [namesapce] --> it changes depend on ToString() overriding
             Console.WriteLine(p1.ToString());  //default: path [namesapce] --> it changes depend on ToString() overriding
             p1.x = 20;
             Console.WriteLine(p1.ToString()); 

             point p2 = new point(1,2);
             Console.WriteLine(p2);             
             Console.WriteLine(p2.ToString());   */
            #endregion

            #region OOP
            // OOP --> object oriented programming  (best programming paradigm)
            // class --> blueprint
            // object --> instance of the class
            // Princibles --> 1. Encabsulation    2. Abstraction    3. Inheritance      4. Polymorphism 
            #endregion

            #region Encapsulation using setters and getters
            /* //Encapsulation --> seperate data (attributes) from it use, use data via getters and setters
            // why getters and setters --> solve three problems:
            //      1. End-user can modify data    2. can't validate data       3. can't make data read only
            // Apply Encapsulation --> 1. make data private     2. access data via setters and getters or properties
            Emplyoee emp1 = new Emplyoee();
            // declare object in stack 
            // CLR allocate 20 bytes in stack (4 int 8 double 8 for string referenec)
            // new select the constructor
            // CLR generate deafult paramterless constructor that intialize fields with default values (0,null,0)
            emp1 = new Emplyoee(1,"mohamed",12000);
            Console.WriteLine(emp1.ToString());
            Console.WriteLine(emp1.getId());
            emp1.setName(null);
            Console.WriteLine(emp1.ToString());*/
            #endregion

            #region Encapsulation using properties
            // properties --> [full, automatic, special (Indexer)]
            // easier in use [recommended]
            // in IL, each property is converted to function includes setter and getter functions.  

            /*Emplyoee emp2 = new Emplyoee();
            emp2.Name = "mo";    //    equal ( = ) for using set 
            Console.WriteLine(emp2.Name);
            //emp2.Id = 10;     Invalid as its read only field
            Console.WriteLine(emp2.Id);
            Console.WriteLine(emp2.Salary);
            Console.WriteLine(emp2.Address);
            Console.WriteLine(emp2.Age);
            emp2.Age = 22;
            Console.WriteLine(emp2.Age);

            emp2 = new Emplyoee(1,"ali",-1000);
            Console.WriteLine(emp2.ToString());*/
            #endregion
            // its recommended to use properties but if we have to write much logic, we can use seters and getters better

            #region Indexer
            // Indexer is special property --> 1. name [this] 
            //                             --> 2. take parameter
            // USED FOR SEARCHING
            /*public object this[int index]
            {
                get { return the specified index here }
                set {  set the specified index to value here  }
            }*/

            /*PhoneBook phoneBook = new PhoneBook(3);
            phoneBook.AddPerson("mohamed", 12345);
            phoneBook.AddPerson("ali", 67891);
            phoneBook.AddPerson("sam", 74125);
            phoneBook.AddPerson("osama", 96352);  // not implemented

            Console.WriteLine(phoneBook["mohamed"]);//12345
            phoneBook["mohamed"] = 54321;
            Console.WriteLine(phoneBook["mohamed"]);//54321
            Console.WriteLine(phoneBook["osama"]);//-1

            Console.WriteLine(phoneBook[12345]);//""
            Console.WriteLine(phoneBook[54321]);//mohamed
            phoneBook[74125] = "sammm";
            Console.WriteLine(phoneBook[74125]);//sammm
            Console.WriteLine(phoneBook["sammm"]);//74125   */
            #endregion

            #region Class
           /* // Reference data type
            Car c1;
            // 1. Declare reference type from car type refers to null
            // 2. CLR allocate 8 bytes in stack
            // 3. CLR allocate 0 bytes in heap
            // 4. c1 car refers to object from type Car or any object of a class that inherits from Car

            c1 = new Car(100,"bmw",1);
            // new do 4 things in this order:
            // 1. allocate the required bytes in Heap (16 bytes: 4 int 4 int 8 string reference)
            // 2. intialize the attributes with the default values
            // 3. call user-defined constructor if exist
            // 4. make c1 refers to the assigned bytes in Heap

            // in [Class], CLR genertae parameterless default constructor that do "NOTHING" as the [new] word makes all things.
            // but default constructor in [struct] assigns attributes with the default values.

            // if there is a user defined constructor --> it cancels the parameterless defult constructor
            // c1 = new Car();         Invalid

            Console.WriteLine(c1);
            Console.WriteLine(c1.ToString());

            c1 = new Car(200, 2);   // refer to new object
            Console.WriteLine(c1);

            c1 = new Car(3);   // refer to new object
            Console.WriteLine(c1);          */
            #endregion
        }//Main
    }// Class
}//namespace
