using System.Security.AccessControl;
using Common;
namespace Session5
{
    internal class Program
    {
        enum Season : byte  //0:255
        {
            winter ,
            automn = 10,
            summer = 251,
            spring
        }
        enum Gender
        {
            male = 1,
            female = 2,
            m = 1,
            f = 2
        }

        [Flags]
        enum Permissions
        {
            read=8,
            write=4,
            Execute=2,
            delete=1
        }
        static void Main(string[] args)
        {
            #region Boxing and UnBoxing
            /*//Boxing: convert from value type to reference type
            //Implicit casting (safe casting)
            object o1;
            o1 = (object)3;           // --> cast from value type [int] to reference type [object]
            o1 = true;                // --> cast from value type [bool] to reference type [object]
            o1 = 'a';                 // --> cast from value type [char] to reference type [object]
            o1 = new DateTime();      // --> cast from value type [DateTime] to reference type [object]

            int x = 5;
            o1 = (object) x;         // x is an object, Implicit casting (safe casting)
            //-------------------------------------------------------------------------
            //UnBoxing: convert from reference type to value type;
            object o2 = new object();
            o2 = 5;
            int y = (int) o2;   // cast from reference type [object] to value type [int]
                                // must be Explicit casing 
                                // un safe casting (may throw Exception)*/
            #endregion

            #region Nullable value type (?)
            /*//value typy --> allow values not null
            // Nullable value type --> allow values or null
            int? age = null; //nullable integer
            double? salary = null; //nullable double

            int x = 5;
            int? y = (int?) x;      //Implicit casting (safe casting)
            //Console.WriteLine(y);

            int? x2 = 5;
            //x2 = null;
            int y2 = (int)x2;       //Explicit casting (un safe casting as may throw exception)
            //Console.WriteLine(y2);  //Excetion: Nullable object must have a value.

            //Defensive code (Brotective code)
            if (x2 != null)
                y2 = (int) x2;
            else y2 = 0;

            if (x2 is not null)
                y2 = (int)x2;
            else y2 = 0;

            // HasValue is a property in Nullable value types that return (true) if value is not null
            if (x2.HasValue)
            {
                y2 = (int) x2;   // Explicit casting (not safe)
                y2 = x2.Value;  // with need to Explicit casting
            }
            else y2 = 0;

            y2 = x2 is not null ? (int) x2 : 0;*/
            #endregion

            #region Null coalescing operator (??)
            /*// used in the check of the value of [null value type]
            int? x = 5;
            x = null;
            int y; 
            y = x.HasValue ? x.Value: 0;
            y = x ?? 0;                     //syntax sugar
            Console.WriteLine(y);*/
            #endregion

            #region Nullable refernce type
            /*// [c# 10 .net 6] for client side
            // default value for reference type  = null;
            string s = null;    // warning: null is required
            string? s2 = null;  // optional
            Console.WriteLine(s2);
            Console.WriteLine(s.Length);  //Null Reference Exception: Object reference (not) set to an instance of an object.
            string s3 = "";
            Console.WriteLine(s3.Length);*/   //0 
            #endregion

            #region Null propagation operator (?)
            /*int x = default;          //0
            double y = default;      //0
            bool z = default;*/   //false

            /*int[] arr2 = new int[3];
            for (int i = 0; i < arr2.Length; i++)
            {
                int.TryParse(Console.ReadLine(), out arr2[i]);
                Console.WriteLine(arr2[i]); 
            }*/

            //int[] arr = default; //null
            //Console.WriteLine(arr.Length);  //Null Reference Exception
            //arr = new int[5];

            /*for (int i = 0; arr is not null && i < arr.Length;i++) 
                Console.WriteLine(arr[i]);*/

            //best practice is to check only one time
            /*if(arr is not null)
                for (int i = 0;i < arr.Length; i++)
                    Console.WriteLine(arr[i]);*/

            // null propagation operator ?
            // ****** check if null returns null else returns the value **********
            // ****** if arr is null --> arr?.Length = null **********
            /*for (int i = 0; i < arr?.Length; i++)
                Console.WriteLine(arr[i]);*/

            //Employee [] EmployeesArray = new Employee [10];
            // EmployeesArray[i]?.Department?.Dname;

            /*Console.WriteLine(arr.Length);        //5
            arr = null;
            Console.WriteLine(arr.Length);          //System.NullReferenceException
            Console.WriteLine(arr?.Length);        //null
            int len = arr?.Length ?? 0;
            Console.WriteLine(len);*/              //0
            #endregion

            #region Exception Handling
            //Exception
            //  1.SystemException
            //      1.1 FormatException
            //      1.2 IndexOutOfRangeException
            //      1.3 NullReferenceException
            //      1.4 ArithmaticException
            //          1.4.1 OverFlowException [assign long into int]
            //          1.4.2 DividedByZeroException
            //  2.ApplicationException [HW]
            //  doSomeCode();
            //finally: code inside it is always implemented.
            //         used for 1.Release or Deallocate from memory --> c# has Garpage collector
            //                  2. Disconnect or Dispose unmanaged resources (disconnect database)
            // doSomeBrotectiveCode();
            #endregion

            #region Access Modifiers
            // c# Library project --> some code to be used in many project
            // It doesnot contain Main function

            //Access Modifiers --> c# keyword for accessability scope
            //1.private             (class scope)
            //2.private protected
            //3.protected
            //4.internal            (project scope)
            //5.internal
            //protected
            //6.public              (everywhere)

            //Inside namespace --> class,  struct,  Interface,  enum
            //Access Modifier inside namespace --> internal,  public
            //Defult access modifier inside namespace is [Internal]

            //to use class from another project --> Dependencies, add project reference, project.dll, using 
            //Common.TypeB = new Common.TypeB();        Invalid as Internal modifier
            TypeA obj = new TypeA();      // valid as public modifier

            //Inside class or struct --> Attributes,    properties,    Methods,    Events
            //Access Modifier inside class --> all access modifiers
            //Defult access modifier inside class is [private]
            //Access Modifier inside struct --> private,    internal,   public
            //Defult access modifier inside struct is [private]
            //  obj.x = 1;      Invalid as the private access modifiers
            //  obj.y = 2;      Invalid as the internal access modifiers
            obj.z = 3;

            //Inside Interface --> signature of methods (declaration)
            //                 --> signature of properties
            //                 --> default implemented method [c# 8 .net 3.1]
            //Access Modifier inside Interface --> all access modifiers except [private] 
            //Defult access modifier inside Interface is [public]
            #endregion

            #region Enum
            /*// Enumeration --> value type  [stack]
            // CLR represent Enum as (integer) value in stack in the memory 
            // start from 0 and incresing +1
            // can specify its data type in memory (range of data type)

            Season s1 = Season.winter;
            Console.WriteLine(s1);          //winter
            Console.WriteLine((int)s1);     //0

            Gender g1 = (Gender) 1;
            Console.WriteLine(g1);          //male

            Gender g2 = (Gender) 2;
            Console.WriteLine(g2);          //female

            Gender g3 = (Gender) 3;
            Console.WriteLine(g3);          //3

            // Enum.parse --> returns object 
            // un boxing : convert from reference type (object) to value type (enum)
            Gender g4 =(Gender) Enum.Parse(typeof(Gender), Console.ReadLine(), true);
            Console.WriteLine(g4);  

            Enum.TryParse(typeof(Gender), Console.ReadLine(), true, out object o1);
            Gender g5 = (Gender)o1;
            Console.WriteLine(g5);*/
            #endregion

            #region Enum permissions
            // items of enum: 2^0  2^1  2^2  2^3 ...
            // Toggle permissions using (^) --> [add permission if not existed]
            //                              --> [remove permission if existed]
            // ADD permissions using (|)
            // Remove permissions using (&~)    NOT Bitwise
            // check permissions using (&)

            /*Permissions p1 = Permissions.read;
            Console.WriteLine(p1);
            Console.WriteLine((int)p1);

            p1 ^= Permissions.delete;
            Console.WriteLine(p1);
            Console.WriteLine((int)p1);

            p1 |= Permissions.write;
            Console.WriteLine(p1);
            Console.WriteLine((int)p1);

            p1 ^= Permissions.delete;
            Console.WriteLine(p1);
            Console.WriteLine((int)p1);

            p1 ^= Permissions.write;
            Console.WriteLine(p1);
            Console.WriteLine((int)p1);

            p1 = p1 | Permissions.write | Permissions.delete;
            Console.WriteLine(p1);
            Console.WriteLine((int)p1);

            p1 &= ~Permissions.delete;
            Console.WriteLine(p1);
            Console.WriteLine((int)p1);

            if ((p1 & Permissions.read) == Permissions.read)
                Console.WriteLine("YES");
            else Console.WriteLine("NO");

            if ((p1 & Permissions.delete) == Permissions.delete)
                Console.WriteLine("YES");
            else Console.WriteLine("NO");*/
            #endregion
        }
        static void doSomeCode()
        {
            try
            {
                int x, y, z;
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
                z = int.Parse(Console.ReadLine());
                z = x / y;
                int[] arr = { 1, 2, 3, 4, 5 };
                arr[99] = 100;
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            finally { Console.WriteLine("Finally"); }
        }
        static void doSomeBrotectiveCode()
        {
            try
            {
                int x, y, z;
                bool flag;
                do
                {
                    Console.WriteLine("Enter Number1: ");
                    flag = int.TryParse(Console.ReadLine(), out x);
                } while (!flag);
                do
                {
                    Console.WriteLine("Enter Number2: ");
                    flag = int.TryParse(Console.ReadLine(), out y);
                } while (!flag || y == 0);
                z = x / y;
                int[] arr = { 1, 2, 3, 4, 5 };
                if (99 < arr?.Length)
                    arr[99] = 100;
                else
                    Console.WriteLine("99 is out of range!!..");
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            finally { Console.WriteLine("Finally"); }
        }
    }//class
}//namespace
