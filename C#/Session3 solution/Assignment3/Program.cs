using System.Text;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.WriteLine("Enter Number: ");
            //bool flag = int.TryParse(Console.ReadLine(), out int value);
            //if (value % 3 == 0 && value % 4 == 0 && flag == true)
            //    Console.WriteLine("Yes");
            //else Console.WriteLine("No");
            #endregion

            #region Q2
            //Console.WriteLine("Enter Number: ");
            //int.TryParse(Console.ReadLine(), out int value);
            //if (value < 0)
            //    Console.WriteLine("Negative");
            //else Console.WriteLine("Positive"); 
            #endregion

            #region Q3
            //Console.WriteLine("Enter 3 Numbers: ");
            //int[] Numbers =  new int[3];
            //for (int i = 0; i < Numbers.Length; i++)
            //    int.TryParse(Console.ReadLine(), out Numbers[i]);
            //int Max = Math.Max(Numbers[0], Math.Max(Numbers[1], Numbers[2]));
            //int Min = Math.Min(Numbers[0], Math.Min(Numbers[1], Numbers[2]));
            //Console.WriteLine($"Max number = {Max}");
            //Console.WriteLine($"Min number = {Min}");
            #endregion

            #region Q4
            //Console.WriteLine("Enter Number: ");
            //bool Flag = int.TryParse(Console.ReadLine(), out int value);
            //if (value % 2 == 0 && Flag == true) Console.WriteLine("even");
            //else if (value % 2 != 0 && Flag == true) Console.WriteLine("odd");
            //else Console.WriteLine("Invalid!");
            #endregion

            #region Q5
            //Console.WriteLine("Enter Character: ");
            //string Character = Console.ReadLine().ToLower();
            //if (Character == "a" || Character == "e" || Character == "o" || Character == "i" || Character == "u")
            //    Console.WriteLine("vowel");
            //else Console.WriteLine("constant");
            #endregion

            #region Q6
            //Console.WriteLine("Enter Number: ");
            //int.TryParse(Console.ReadLine(), out int Value);
            //int Counter = 1;
            //while (Counter <= Value)
            //{
            //    Console.Write( $"{Counter}, ");
            //    ++Counter;
            //}
            #endregion

            #region Q7
            //Console.WriteLine("Enter Number: ");
            //int.TryParse(Console.ReadLine(), out int value);
            //for (int i = 1; i <= 12; i++) { 
            //    Console.Write($"{value * i} ");
            //}
            #endregion

            #region Q8
            //Console.WriteLine("Enter Number: ");
            //int.TryParse(Console.ReadLine(), out int Value);
            //int Counter = 2;
            //while (Counter <= Value)
            //{
            //    if (Counter % 2 == 0) Console.Write($"{Counter} ");
            //    ++Counter;
            //}
            #endregion

            #region Q9
            //int Base, Power, result=1;
            //Console.WriteLine("Enter Number: ");
            //int.TryParse(Console.ReadLine(), out Base);
            //Console.WriteLine("Enter Power: ");
            //int.TryParse(Console.ReadLine(), out Power);
            //for (int i = 1; i <= Power; i++)
            //    result *= Base ;
            //Console.WriteLine(result);
            #endregion

            #region Q10
            //Console.WriteLine("Enter Marks: ");
            //int[] Marks = new int[5];
            //int total = 0;
            //float avg = 0;
            //for (int i = 0; i < Marks.Length; i++) 
            //{
            //   Marks[i] = int.Parse(Console.ReadLine());
            //   total += Marks[i];
            //}
            //avg = total / 5;
            //Console.WriteLine($"Total Marks = {total}");
            //Console.WriteLine($"Average Marks = {avg}");
            //Console.WriteLine($"Percentage = {avg} %");
            #endregion

            #region Q11
            //int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            //Console.WriteLine("Enter Month Number: ");
            //int.TryParse(Console.ReadLine(), out int value);
            //if (value > 0 && value <= 12) { Console.WriteLine($"Days in Month = {days[value - 1]}"); }
            //else { Console.WriteLine("Invalid!!"); }
            #endregion

            #region Q12
            //int Value1, Value2;
            //Console.WriteLine("Enter Number 1:");
            //int.TryParse(Console.ReadLine(), out Value1);
            //Console.WriteLine("Enter Number 2:");
            //int.TryParse(Console.ReadLine(), out Value2);
            //Console.WriteLine("Enter operation +, - , *, /");
            //string Operation = Console.ReadLine();
            //switch (Operation)
            //{
            //    case "+":
            //        Console.WriteLine($"Result = {Value1 + Value2}");
            //        break;
            //    case "-":
            //        Console.WriteLine($"Result = {Value1 - Value2}");
            //        break;
            //    case "*":
            //        Console.WriteLine($"Result = {Value1 * Value2}");
            //        break;
            //    case "/":
            //        if (Value2 != 0) Console.WriteLine($"Result = {Value1 / Value2}");
            //        else Console.WriteLine("Invalid");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Opeartors");
            //        break;
            //}
            #endregion

            #region Q13
            //string Reversed="";
            //Console.WriteLine("Enter String: ");
            //string Input = Console.ReadLine();
            //for (int i = Input.Length-1; i >=0; i--)
            //    Reversed+=Input[i];
            //Console.WriteLine(Reversed);
            #endregion

            #region Q14
            //Console.WriteLine("Enter Number: ");
            //int.TryParse(Console.ReadLine(), out int Number);
            //int remain, reversed = 0;
            //while (Number!=0)
            //{
            //    remain = Number % 10;
            //    reversed = (reversed*10) + remain;
            //    Number /= 10;
            //}
            //Console.WriteLine($"Reversed Number: {reversed}");
            #endregion

            #region Q15
            //int counter;
            //Console.WriteLine("Enter starting Number of range");
            //int.TryParse(Console.ReadLine(), out int Start);
            //Console.WriteLine("Enter ending Number of range");
            //int.TryParse(Console.ReadLine(), out int End);
            //Console.WriteLine($"The prime number between {Start} and {End} are :");
            //for (int i = Start; i <= End; i++) {
            //    counter = 0;
            //    for (int j = 1; j <= i; j++) {
            //        if (i % j == 0) ++counter;
            //    }
            //    if (counter <= 2) Console.Write($"{i} ");
            //}
            #endregion

            #region Q16
            //Console.WriteLine("Enter Number: ");
            //int.TryParse(Console.ReadLine(), out int Number);
            //string ReversedBinary = "";
            //while (Number != 0)
            //{
            //    ReversedBinary += Number % 2;
            //    Number /= 2;
            //}
            //for (int i = ReversedBinary.Length - 1; i >= 0; i--)
            //    Console.Write(ReversedBinary[i]);
            #endregion

            #region Q17
            //Console.WriteLine("Enter the first point (x1,y1): ");
            //double x1 = double.Parse(Console.ReadLine());
            //double y1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the second point (x2,y2): ");
            //double x2 = double.Parse(Console.ReadLine());
            //double y2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the third point (x3,y3): ");
            //double x3 = double.Parse(Console.ReadLine());
            //double y3 = double.Parse(Console.ReadLine());
            //if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
            //    Console.WriteLine("The three points are on a straight line");
            //else
            //    Console.WriteLine("Not on a straight line");
            #endregion

            #region Q18
            //Console.WriteLine("Enter Time taken for the task: ");
            //double time = double.Parse(Console.ReadLine());
            //if (time >= 2 && time <= 3)
            //    Console.WriteLine("highly efficient");
            //else if (time > 3 && time <= 4)
            //    Console.WriteLine("they are instructed to increase their speed.");
            //else if (time > 4 && time <= 5)
            //    Console.WriteLine("they are provided with training to enhance their speed.");
            //else Console.WriteLine("they are required to leave the company.");
            #endregion

            #region Q19
            //Console.WriteLine("Enter Size of the identity matrix: ");
            //int.TryParse(Console.ReadLine(), out int value);
            //int[,] matrix = new int[value,value];
            //for (int r = 0; r < value; r++)
            //{
            //    for (int c = 0; c < value; c++)
            //    { 
            //        if(r == c)
            //            matrix[r,c] = 1;
            //        else
            //            matrix[r,c] = 0;
            //    }
            //}
            //for (int r = 0; r < value; r++)
            //{
            //    for (int c = 0; c < value; c++)
            //        Console.Write($"{ matrix[r,c] } "); 
            //    Console.WriteLine();
            //}
            #endregion

            #region Q20
            //int[] array = { 1, 2, 3, 4, 5 };
            //int sum = 0;
            //for (int i = 0; i < array.Length; i++)
            //    sum += array[i]; 
            //Console.WriteLine(sum);
            #endregion

            #region Q21
            //int[] array1 = { 7, 1, 8, 9, 2 };
            //int[] array2 = { 3, 4, 6, 5, 9 };
            //int[] MergeArray = new int[array1.Length*2];
            //for (int i = 0; i < array1.Length; i++)
            //    MergeArray[i] = array1[i];
            //for (int i = 0; i < array2.Length; i++)
            //    MergeArray[5+i] = array2[i];
            //Array.Sort(MergeArray);
            //foreach (int i in MergeArray)
            //    Console.Write($"{i} ");
            #endregion

            #region Q22
            //int[] array = { 1, 2, 3, 2, 4, 7, 2, 7, 1, 3, 4, 8, 4, 2 };
            //int number, frequancy;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    number = array[i];
            //    frequancy = 1;
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (number == array[j])
            //            frequancy++;
            //    }
            //    for (int j = i + 1; j < array.Length; j++)
            //    {
            //        if (number == array[j])
            //            frequancy++;
            //    }
            //    Console.WriteLine($" Number {array[i]} has frequancy = {frequancy}");
            //}
            #endregion

            //Another solution
            #region Q22
            //int[] array = { 1, 2, 3, 2, 4, 7, 2, 7, 1, 3, 4, 8, 4, 2 };
            //Dictionary<int, int> frequency = new Dictionary<int, int>();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (frequency.ContainsKey(array[i]))
            //        frequency[array[i]]++;
            //    else frequency[array[i]] = 1;
            //}
            //foreach (int i in frequency.Keys)
            //    Console.WriteLine($" Number {i} has frequancy = {frequency[i]}");
            #endregion

            #region Q23
            //int[] array = { 4, 2, 7, 9, 5, 6, 3, 1 };
            //Array.Sort(array);
            //Console.WriteLine($"Max = {array[array.Length - 1]}");
            //Console.WriteLine($"Min = {array[0]}");
            #endregion

            #region Q24
            //int[] array = { 4, 2, 7, 9, 5, 6, 3, 1 };
            //Array.Sort(array);
            //Console.WriteLine($"Second Max = {array[array.Length - 2]}");
            #endregion

            #region Q25
            //Console.WriteLine("Enter Array Size: ");
            //int.TryParse(Console.ReadLine(), out int Size);
            //int[] array = new int[Size];
            //Console.WriteLine("Enter Array Elements: ");
            //for (int i = 0; i < Size; i++)
            //    int.TryParse(Console.ReadLine(), out array[i]);
            //int distance, secondDistance, maxDistance=0, number;
            //for (int i = 0; i < Size; i++)
            //{
            //    number = array[i];
            //    distance = 0; secondDistance = 0;
            //    for(int j = i+1; j < Size; j++)
            //    {
            //        if (array[j] != number)
            //            distance++;
            //        else
            //        {
            //            secondDistance += distance;
            //            distance = 1;
            //        }
            //    }
            //    if(secondDistance > maxDistance)
            //        maxDistance = secondDistance;
            //}
            //Console.WriteLine($"Max Distance = {maxDistance}");
            #endregion

            #region Q26
            //Console.WriteLine("Enter String: ");
            //string Input = Console.ReadLine();
            //string[] words = Input.Split(" ");
            //string reversed = "";
            //for (int i = words.Length - 1; i >= 0; i--)
            //    reversed += words[i] + " ";
            //Console.WriteLine(reversed);
            #endregion

            #region Q27
            //int [,] array1 = new int[3, 3];
            //int[,] array2 = new int[3, 3];
            //Console.WriteLine("Enter Array Elements: ");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine($"Enter Element [{i},{j}]: ");
            //        int.TryParse(Console.ReadLine(), out array1[i, j]);
            //    }
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        array2[i, j] = array1[i, j];
            //        Console.Write($"{array2[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Q28
            //int [] array = { 1, 2, 3, 4, 5 };
            //for (int i = array.Length - 1; i >= 0; i--)
            //    Console.Write($"{array[i]} ");
            #endregion
        }
    }
}
