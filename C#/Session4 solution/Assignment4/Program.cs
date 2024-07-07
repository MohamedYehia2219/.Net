namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //passing by value
            //pass copy of values 
            /*int x=3, y=4;
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

            #region Q2
            // passing by value
            // pass copy of address
            /*int[] array = { 1, 2, 3 };
            int sum = sumArray(array);
            Console.WriteLine(sum);
            Console.WriteLine(array[0]);

            // passing by reference
            // pass address (array it self)
            int[] array2 = { 1, 2, 3 };
            int sum2 = sumArrayByRef(ref array2);
            Console.WriteLine(sum2);
            Console.WriteLine(array2[0]);*/
            #endregion

            #region Q3
            //math(10, 5, out int sum, out int subb);
            //Console.WriteLine($"sum = {sum}  ,  subtract = {subb}");
            #endregion

            #region Q4
            /*Console.WriteLine("Enter Number: ");
            int.TryParse( Console.ReadLine(), out int number);
            int sum = sumDigits(number);
            Console.WriteLine($"sum digits = {sum}");*/
            #endregion

            #region Q5
            /*Console.WriteLine("Enter number:");
            int.TryParse(Console.ReadLine(), out var number);
            Console.WriteLine(isPrime(number));*/
            #endregion

            #region Q6
            /*double min = 0, max = 0;
            double[] array = { 7, 4, 1, 5, 8, 2 };
            MinMaxArray(array,ref min,ref max);
            Console.WriteLine($"min = {min}  ,  max = {max}");*/
            #endregion

            #region Q7
            /*Console.WriteLine("Enter Number: ");
            int.TryParse(Console.ReadLine(), out int value);
            Console.WriteLine($"factorial =  {Factorial(value)}");*/
            #endregion

            #region Q8
            //Console.WriteLine(ChangeChar("Mohamed", 4, 'H'));
            //Console.WriteLine(ChangeChar2("Mohamed", 6, 'H'));
            #endregion
        }
        static void swap(int x, int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
        static void swapByRef(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
        static int sumArray(int[] array)
        {
            array = new int[] { 4, 5, 6 };
            int sum = 0;
            for (int i = 0; i < array.Length; i++) sum += array[i];
            return sum;
        }
        static int sumArrayByRef(ref int[] array)
        {
            array = new int[] { 4, 5, 6 };
            int sum = 0;
            for (int i = 0; i < array.Length; i++) sum += array[i];
            return sum;
        }
        static void math(int x, int y, out int sum, out int sub)
        {
            sum = x + y;
            sub = x - y;
        }
        static int sumDigits(int number)
        {
            int sum = 0, remain;
            while (number != 0)
            {
                remain = number % 10;
                sum += remain;
                number /= 10;
            }
            return sum;
        }
        static bool isPrime(int number)
        {
            int counter = 0;
            for (int i = 1; i <= number; i++)
            { 
                if(number%i == 0)
                    counter++;
            }
            if(counter == 2) return true;
            return false;
        }
        static void MinMaxArray(double[] array, ref double min, ref double max)
        {
            Array.Sort(array);
            min = array[0];
            max = array[array.Length - 1];
        }
        static int Factorial(int number)
        {
            int factorial = 1;
            for(int i = 1; i <= number; i++)
                factorial *= i;
            return factorial;
        }

        static string ChangeChar(string text, int position, char character)
        {
            if(position >= 0 && position < text.Length) 
                text = text.Replace(text[position], character);
            return text;
        }
        static string ChangeChar2(string text, int position, char character)
        {
            if (position >= 0 && position < text.Length)
                text = text.Substring(0, position) + character + text.Substring(position + 1);
            return text;
        }
    }//class
}//namespace
