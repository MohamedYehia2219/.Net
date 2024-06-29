using System.Net.Sockets;

namespace Session2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region revision
            // comment --> ctrl + k + c
            // region --> ctrl + k + s
            //Console.WriteLine("Hello, World!");
            //Console.ReadKey(); 
            #endregion

            #region Variable declaration
            //Variable Declaration
            // variable: value container in memory
            // data tybe, name (pascal case), value, address(hexa decimal) 
            // variable name can't be a reserved word (class, namespace, int,...) 
            // naming convention:
            //PascalCase --> FirstNmae
            //camelCase --> firstName
            //kabab_case--> first_name
            /*int Number;         //declaration
            Number = 10;        // initialization
            Console.WriteLine(Number);
            int Number1 = 10, Number2 = 20;
            Console.WriteLine(Number1 + Number2);*/
            #endregion

            #region Value Type (primitive)
            //Data types (value type - primitive)
            //int Number1;        //c# keyword
            //Int32 Number2 = 10;
            //Number1 = Number2;
            //Console.WriteLine("Number1 = " + Number1);
            //Console.WriteLine("Number2 = " +  Number2); 
            #endregion

            #region Refrence Type (Non - primitive)
            /*Point p1;
            // allocate refrence in the Stack
            // 8 bytes have been allocated in Stack
            // 0 bytes have been allocated in Heap
            p1 = new Point();
            // new: 1- allocte the required bytes for the obj in the Heap --> ( 8 + CLR overhead bytes )
            //      2- intialize bytes in Heap with the defaulat value
            //      3- call the user defined constructor if exists
            //      4- assign the allocated obj in Heap to the reference in the Stack
            Point p2 = new Point();
            p2 = p1;    //  p2 referes to p1
            p2.y = 5;
            Console.WriteLine(p1.y);
            Console.WriteLine(p2.y);
            Console.WriteLine(p1.x);*/
            #endregion

            #region Object
            //Point p1 = new Point();
            //Console.WriteLine(p1);              //name space 
            //Console.WriteLine(p1.ToString());   //name space

            //object o1 = new object();
            //Console.WriteLine(o1);
            //o1 = new String("mohamed");
            //Console.WriteLine(o1);
            //o1 = "yehia";
            //o1 = 3.14;
            //o1 = true;

            //object o2 = new object();   
            //object o3 = new object();
            //Console.WriteLine(o2.GetHashCode() +"\t" + o3.GetHashCode());
            //o2 = o3;
            //Console.WriteLine(o2.GetHashCode() + "\t" + o3.GetHashCode());
            #endregion

            #region Casting
            // ********** implicit (safe casting)
            //int x = 4;
            //double y = x;
            //long z = x;

            // *************** Explicit (unsafe casting)
            //int x1 = 5;
            //long y1 = 321;
            //x1 = (int) y1;
            //Console.WriteLine(x1);

            //int x2;
            //long y2 = 321456789741285963;
            //x2 = (int) y2;
            //Console.WriteLine(x2);  // random number

            //int x3 = 5;
            //long y3;
            //checked
            //{
            //    unchecked
            //    {
            //        y3 = 321456789741285963;
            //    }
            //    x3 = (int) y3;   // System.OverflowException: Exception
            //}
            //Console.WriteLine(x3);
            #endregion

            #region Parsing
            //int x = int.Parse("123");
            //Console.WriteLine(x+1);

            //Console.WriteLine("Enter age");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter GPA");
            //double gpa = double.Parse(Console.ReadLine());
            //Console.WriteLine("age: " + age + "\t" + "GPA: " + gpa);

            //Console.WriteLine("Enter age");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter GPA");
            //double gpa = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("age: " + age + "\t" + "GPA: " + gpa);

            //int age;
            //bool flag = int.TryParse(Console.ReadLine(), out age);
            //Console.WriteLine(age + "\t" + flag);
            #endregion

            #region Fractions
            //fractions
            //2.5 --> double
            //double x = 2.5;
            //float y1 = 2.5f;
            //float y2 = (float)2.5;
            //decimal z1 = 2.5m;
            //decimal z2 = (decimal)2.5;

            //// Discard (readability)
            //long a = 100_000_000;
            //Console.WriteLine(a);
            #endregion

            #region operators
            //1- unary operators --> works on one variable ++, --
            /* int x = 10;
            // prefix [increment then print]
            Console.WriteLine(++x);                 //11
            //postfix [print then increment]
            Console.WriteLine(x++);                //11
            Console.WriteLine(x); */                //12

            //2- binary operators (+,-,*,/,%)
            //int Number1 = 2, Number2 = 6;
            //Console.WriteLine(Number1%Number2);

            //3- Assignment operators
            //int x = 4;
            //x += 2;
            //x -= 2;
            //x /= 2;
            //x *= 2;
            //x %= 2;     // x = x%2

            //4- Relational operators (comparison)
            //int x= 5; int y= 10;
            //Console.WriteLine(x == 10);
            //Console.WriteLine(x == y);
            //Console.WriteLine(x >= y);
            //Console.WriteLine(x > y);
            //Console.WriteLine(x < y);
            //Console.WriteLine(x <= y);
            //Console.WriteLine(x != y);

            //5- Logical operators [!, ||, &&] (AND, OR short circles)
            //Console.WriteLine(!false);
            //Console.WriteLine(false || true);
            //Console.WriteLine(false && true);

            //6- Logical operators [!, |, &] (AND, OR long circles)
            //Console.WriteLine(!false);
            //Console.WriteLine(false | true);
            //Console.WriteLine(false & true);

            //7- Ternary operator [conditional]
            //bool flag = 4 > 2;
            //Console.WriteLine(flag);
            //string flag2 = 4 > 2 ? "correct" : "not correct";
            //Console.WriteLine(flag2);

            //operators priority [precedence]
            // 1- unary operators
            // 2- round braces ()
            // 3- *,/
            // 4- +,-
            #endregion
        }
    }
}
