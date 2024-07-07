namespace Session4
{
    // namespace includes only --> 1.Classes    2.Interfaces     3.Struct        4.Enum
    // function are written in Classes, Interfaces and Struct.
    class math
    {
        public int sum;
        public int mul;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1D Array
            /*int[] array;
            //declare reference from type array in the satck 
            // CLR will allocate 8 bytes at stack
            array = new int[5];
            //CLR will allocate 5*4 = 20 bytes in heap
            // array reference will refer to the array in heap
            // intial value for all array elements = 0;
            int[] array2 = new int[3] { 1, 2, 3 };
            int[] array3 = new int[] { 1, 2, 3 };
            int[] array4 = { 1, 2, 3 };
            Console.WriteLine(array.Length);
            Console.WriteLine(array.Rank); // Dimention
            for (int i = 0; i < array.Length; i++) Console.WriteLine(array[i]);
            foreach (int i in array2) Console.WriteLine(i);*/
            #endregion

            #region 2D Array
            /*int[,] array = new int[3,3];
            Console.WriteLine(array.Length);    //9
            // intial values for all elements = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Enter element array[{i}, {j}] :");
                    int.TryParse(Console.ReadLine(), out array[i,j]);
                }
            }*/
            #endregion

            #region Judge Array
            /*// each row has different size of elements
            int[][] array = new int[3][];
            array[0] = new int[] {1,2,3};
            array[1] = new int[] {4,5,6,7};
            array[2] = new int[] {8,9};
            Console.WriteLine(array.Length);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                    Console.Write($"{array[i][j]} ");
                Console.WriteLine();
            }*/
            #endregion

            #region Function
            /*//class member function (static)
            Array.Sort(new int[] { 1,2,3});
            //object member function
            int [] numbers = { 1,2,4 };
            numbers.Clone();
            //static functions must call static functions inside it
            printShape("^_^", 5); //passing parameters by order
            printShape(pattern:"^_^",counter:7); //pass parameters by name
            printShape(":)");   //default parameters*/
            #endregion

            #region value type parameters
            /*//passing by value
            //pass copy of values 
            int x=3, y=4;
            Console.WriteLine($"before swapping: x = {x}, y = {y}");
            swap(x,y);
            Console.WriteLine($"after swapping: x = {x}, y = {y}");

            //passing by refernce
            //pass address of the variable (variable itself)
            int a = 5, b = 10;
            Console.WriteLine($"before swapping: a = {a}, b = {b}");
            swapByRef(ref a,ref b);
            Console.WriteLine($"after swapping: a = {a}, b = {b}");*/
            #endregion

            #region reference type parameters
            // passing by value
            // pass copy of address
            /*int[] array = { 1, 2, 3 };
            int sum = sumArray(array);
            Console.WriteLine(sum);
            Console.WriteLine(array[0]);*/

            // passing by reference
            // pass address (array it self)
            /*int[] array2 = { 1, 2, 3 };
            int sum2 = sumArrayByRef(ref array2);
            Console.WriteLine(sum2);
            Console.WriteLine(array2[0]);*/
            #endregion

            #region reference type parameters example2
            // passing by value
            // pass copy of address
            /*int[] array = { 1, 2, 3 };
            int sum = sumArray2(array);
            Console.WriteLine(sum);
            Console.WriteLine(array[0]);*/

            // passing by reference
            // pass address (array it self)
            /*int[] array2 = { 1, 2, 3 };
            int sum2 = sumArrayByRef2(ref array2);
            Console.WriteLine(sum2);
            Console.WriteLine(array2[0]);*/
            #endregion

            #region out parameter
            /*// to return more than value
            // return array
            int[] array = SumMul(5, 10);
            Console.WriteLine($"sum = {array[0]} , mul = {array[1]}");

            // return object
            math obj = new math();
            obj = SumMul2(2, 4);
            Console.WriteLine($"sum = {obj.sum} , mul = {obj.mul}");

            //using out
            SumMul3(1, 2, out int sum, out int mul);
            Console.WriteLine($"sum = {sum} , mul = {mul}");

            //can use (_) for not passing out parameter
            SumMul3(1, 2, out _, out _);

            // using passing by ref
            int summ = 0, mull = 0;
            SumMul4(4, 7,ref summ,ref mull);
            Console.WriteLine($"sum = {summ} , mul = {mull}");*/
            #endregion

            #region params
            /*// to send array or elemnts for array in function call
            // must be the last parameters in function call
            paramsArray(out int sum, 1, 2, 3, 4, 5);
            Console.WriteLine(sum);

            int[] arr = { 1, 2, 3 };
            paramsArray(out int sum2,arr);
            Console.WriteLine(sum2);*/
            #endregion
        }// Main function

        static void printShape(string pattern, int counter = 10)
        { 
            for (int i = 0; i < counter; i++) Console.WriteLine(pattern);
        }
        static void swap(int x, int y)
        {
            int temp;
            temp = x;   
            x = y;
            y = temp;
        }
        static void swapByRef(ref int a,ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
        static int sumArray(int[] array)
        {
            array[0] = 100;
            int sum = 0;
            for (int i = 0;i < array.Length;i++) sum+=array[i];
            return sum;
        }
        static int sumArrayByRef(ref int[] array)
        {
            array[0] = 100;
            int sum = 0;
            for (int i = 0; i < array.Length; i++) sum += array[i];
            return sum;
        }
        static int sumArray2(int[] array)
        {
            array = new int[] {4,5,6};
            int sum = 0;
            for (int i = 0; i < array.Length; i++) sum += array[i];
            return sum;
        }
        static int sumArrayByRef2(ref int[] array)
        {
            array = new int[] {4, 5,6 };
            int sum = 0;
            for (int i = 0; i < array.Length; i++) sum += array[i];
            return sum;
        }
        static int[] SumMul(int x, int y)
        {
            int sum = x + y;
            int mul = x * y;
            return new int[] { sum, mul };
        }
        static math SumMul2(int x, int y)
        {
            math obj = new math();
            obj.sum = x+y; ;
            obj.mul = x*y; ;
            return obj;
        }
        static void SumMul3(int x, int y, out int sum, out int mul)
        {
            sum = x + y;
            mul = x * y;
        }
        static void SumMul4(int x, int y, ref int sum, ref int mul)
        {
            sum = x + y;
            mul = x * y;
        }
        static void paramsArray(out int sum, params int[] array)
        {
            sum = 0;
            for (int i = 0; i< array.Length; i++)
                sum += array[i];
        }
    }//class
}//namespace
