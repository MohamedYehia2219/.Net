namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.WriteLine(Console.ReadLine());    //as string
            //Console.WriteLine("Enter a Number");
            //float Number = float.Parse(Console.ReadLine());
            //Console.WriteLine(Number); 
            #endregion

            #region Q2
            //If there are characters, that will lead to an Exception 
            //int Number = int.Parse(Console.ReadLine());
            //Console.WriteLine(Number);

            //using TryParse, if there are characters, the int number will = 0 
            //int Number2;
            //int.TryParse(Console.ReadLine(),out Number2);
            //Console.WriteLine(Number2);
            #endregion

            #region Q3
            //float Number1 = 5.5f;
            //float Number2 = 4.5f;
            //float sum = Number1 + Number2;
            //float difference = Number1 - Number2;
            //Console.WriteLine("Sum: " + sum);
            //Console.WriteLine("Difference: " + difference);
            #endregion

            #region Q4
            //Console.WriteLine("Enter string");
            //string Input = Console.ReadLine();
            //Console.WriteLine(Input.Substring(0,1));
            #endregion

            #region Q5
            //int x = 5;
            //int y = x;
            //Console.WriteLine("X = " + x + "\t" + "Y = "+ y);
            //x = 7;
            //Console.WriteLine("X = " + x + "\t" + "Y = " + y);
            #endregion

            #region Q6
            //point p1 = new point();
            //p1.x = 5;
            //point p2 = new point();
            //p2 = p1;
            //Console.WriteLine(p2.x);
            //p2.x = 7;
            //Console.WriteLine(p1.x);
            #endregion

            #region Q7
            //Console.WriteLine("Enter string 1");
            //string s1 = Console.ReadLine();
            //Console.WriteLine("Enter string 2");
            //string s2 = Console.ReadLine();
            //string s = s1 + " " + s2;
            //Console.WriteLine(s);
            #endregion

            #region Q8
            //Console.WriteLine("Enter principal");
            //float Principal = float.Parse(Console.ReadLine());
            //Console.WriteLine("Enter rate");
            //float Rate = float.Parse(Console.ReadLine());
            //Console.WriteLine("Enter time");
            //float Time = float.Parse(Console.ReadLine());
            //float Interest = (Principal * Rate * Time) / 100;
            //Console.WriteLine("Interest = " + Interest);
            #endregion

            #region Q9
            //Console.WriteLine("Enter Weight");
            //float Weight = float.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Height");
            //float Height = float.Parse(Console.ReadLine());
            //float BMI = Weight / (Height * Height);
            //Console.WriteLine("BMI = " + BMI);
            #endregion

            #region Q10
            //Console.WriteLine("Enter Temperature");
            //float Temperature = float.Parse(Console.ReadLine());
            //string result;
            //result = Temperature < 10 ? "Cold" : (Temperature > 30 ? "Hot" : "Good");
            //Console.WriteLine(result);
            #endregion

            #region Q11
            //Console.WriteLine("Enter Day");
            //string day = Console.ReadLine();
            //Console.WriteLine("Enter month");
            //string month = Console.ReadLine();
            //Console.WriteLine("Enter year");
            //string year = Console.ReadLine();
            //Console.WriteLine($"Today’s date : {day}/{month}/{year}");
            //Console.WriteLine($"Today’s date : {day},{month},{year}");
            //Console.WriteLine($"Today’s date : {day}-{month}-{year}");
            #endregion

            #region Q12
            //DateTime date = new DateTime(2024, 6, 14); 
            //Console.WriteLine($"The event is on {date:MM/dd/yyyy}");
            //The event is on 06/14/2024
            #endregion

            #region Q13
            //int d;
            //d = Convert.ToInt32(!(30 < 20));
            //Console.WriteLine(d);   // d=1
            //int x = Convert.ToInt32(true);
            //Console.WriteLine(x);
            #endregion

            #region Q14
            //Console.WriteLine(13 / 2 + " " + 13 % 2);   //  6  1
            #endregion

            #region Q15
            //int num = 1, z = 5;
            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z);     //7 7 
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);
            #endregion
        }
    }
}
