using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Session3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String Formatting
            /*// string is Immutable (can,t change its value after creation)
            string Message = "Equation: 2 + 4 = 6";
            Console.WriteLine(Message);

            int x = 2, y = 4;

            //1- concatination --> with each concat,  a new object is created in Heap 
            Console.WriteLine("Equation: " + x + " + " + y+ " = "+ (x+y));

            //2- composite formatting
            string Message2 = string.Format("Equation: {0} + {1} = {2}", x,y,x+y);
            Console.WriteLine(Message2);

            //3- String Interpolation 
            // Manipolation operator ($)
            Console.WriteLine($"Equation: {x} + {y} = {x+y}");*/
            #endregion

            #region If condition
            /*Console.WriteLine("Enter number of month in the first q");
            int.TryParse(Console.ReadLine(), out int value);
            if (value == 1) Console.WriteLine("Jan");
            else if (value == 2) Console.WriteLine("Feb");
            else if (value == 3) Console.WriteLine("March");
            else Console.WriteLine("Invalid");

            // swithch
            // use JUMP TABLE
            switch(value)
            {
                case 1: 
                    Console.WriteLine("Jan");
                    break;
                case 2:
                    Console.WriteLine("Feb");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }*/
            #endregion

            #region switch
            //Jump Table
            /*Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
            switch (name)
            {
                case "Ahmed":
                    Console.WriteLine("Hello Ahmed :) ");
                    break;
                case "Omar":
                    Console.WriteLine("Hello Omar :) ");
                    break;
                case "Mai":
                    Console.WriteLine("Hello Mai :) ");
                    break;
                case "Mariem":
                    Console.WriteLine("Hello Mariem :) ");
                    break;
            }*/
            #endregion

            #region goto
            // goto
            /*Console.WriteLine("Enter Budget:");
            int.TryParse(Console.ReadLine(), out var Budget);
            switch (Budget)
            {
                case 3000:
                    Console.WriteLine("option 03");
                    goto case 2000;
                case 2000:
                    Console.WriteLine("option 02");
                    goto case 1000;
                case 1000:
                    Console.WriteLine("option 01");
                    break;
                default:
                    Console.WriteLine("Invalid Budget");
                    break;
            }*/
            #endregion

            #region comparison in switch 
            /*Console.WriteLine("Enter Age:");
            int.TryParse(Console.ReadLine(), out var age);
            switch (age)
            {
                case > 20:
                    Console.WriteLine("Welcome");
                    break;
                case < 20:
                    Console.WriteLine("Bye Bye");
                    break;
                default:
                    Console.WriteLine("Equal");
                    break;
            }*/
            #endregion

            #region Evaluation of switch
            /*object obj = new object();
            obj = 1;
            obj = -1;
            obj = 1.5;
            obj = "hi";
            obj = 0.0;
            obj = 0;
            switch (obj)
            {
                case int Input when Input  > 0:
                    Console.WriteLine("int Positive");
                    break;
                case int Input when Input < 0:
                    Console.WriteLine("int Negative");
                    break;
                case double Input:
                    Console.WriteLine("double");
                    break;
                case string Input:
                    Console.WriteLine("string");
                    break;
                default:
                    Console.WriteLine("other");
                    break;
            }*/
            #endregion

            #region switch C# 8.0
            /*Console.WriteLine("Enter option");
            string option = Console.ReadLine();
            string output;
            output = option switch
            {
                "1" => "Using option 1",
                "2" => "Using option 2",
                "3" => "Using option 3",
            };
            Console.WriteLine(output);*/
            #endregion

            #region For
            /*for(int i = 1; i <= 10; i++) 
                Console.WriteLine(i);

            int[] array = { 1,2,3,4,5,6,7};
            foreach (int i in array)
                Console.WriteLine(i);*/
            #endregion

            #region while, do..while
            /*Console.WriteLine("Enter age");
            int age;
            int.TryParse(Console.ReadLine(), out age);
            while (age <= 0)
            {
                Console.WriteLine("Enter age again");
                int.TryParse(Console.ReadLine(), out age);
            }*/

            /*Console.WriteLine("Enter even number");
            int number;
            int.TryParse(Console.ReadLine(), out number);
            while (number %2 != 0)
            {
                Console.WriteLine("Enter even number again");
                int.TryParse(Console.ReadLine(), out number);
            }*/

            /*int number;
            do
            {
                Console.WriteLine("Enter even number");
                int.TryParse(Console.ReadLine(), out number);
            } while (number % 2 != 0);*/
            #endregion

            #region string
            /*  // string is reference class
            // string is Immutable type
            string name;
            // declare reference from type string refer to null
            //CLR: allocate 8 bytes in stack
            //CLR: allocate 0 bytes in heap
            name = new string("Ahmed");
            name = "Ahmed"; // syntax sugar
            // CLR: allocate 10 bytes in Heap

            string name1 = "ahmed";
            string name2 = "mohamed";
            Console.WriteLine(name1 + ": " + name1.GetHashCode());
            Console.WriteLine(name2 + ": " + name2.GetHashCode());

            name2 = name1;
            Console.WriteLine(name1 + ": " + name1.GetHashCode());
            Console.WriteLine(name2 + ": " + name2.GetHashCode());

            name2 = "ali";  // Immutable  --> changing its value lead to create new object
            Console.WriteLine(name1 + ": " + name1.GetHashCode());
            Console.WriteLine(name2 + ": " + name2.GetHashCode());

            string massage = "hello";
            Console.WriteLine(massage + ": " + massage.GetHashCode());
            massage += "mohamed";
            Console.WriteLine(massage + ": " + massage.GetHashCode());*/
            #endregion

            #region string builder
            /*//StringBuilder is Type reference [class]
            // stringBuilder is (Mutable) --> can change its value with out creating new object
            StringBuilder massage = new StringBuilder("hello");
            Console.WriteLine(massage + ": " + massage.GetHashCode());
            // massage += "mohamed";    -- Invalid
            massage.Append(" mohamed");  // Mutable
            Console.WriteLine(massage + ": " + massage.GetHashCode());*/
            #endregion
        }
    }
}
