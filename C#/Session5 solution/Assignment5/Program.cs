using System.Reflection;

namespace Assignment5
{
    internal class Program
    {
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday, 
            Saturday,
            Sunday,
        }
        enum Season 
        {
            Winter,
            Automn,
            Summer,
            Spring
        }

        [Flags]
        enum Permissions
        {
            read = 8,
            write = 4,
            Execute = 2,
            delete = 1
        }

        enum Color
        {
            red,
            green, 
            blue
        }
        static void Main(string[] args)
        {
            //Q1();
            //Q2();
            //Q3();
            //Q4();
        }
        static void Q1()
        {
            WeekDays[] days = new WeekDays[7];
            for (int i = 0; i < days?.Length; i++)
            {
                days[i] = (WeekDays)i;
                Console.WriteLine($"{days[i]}");
            }
        }
        static void Q2() 
        {
            object o1;
            bool flag;
            do
            {
                Console.WriteLine("Enter Season: ");
                flag = Enum.TryParse(typeof(Season), Console.ReadLine(), true, out o1);
            }while(!flag);
            Season s = (Season)o1;
            if (s == Season.Winter)
                Console.WriteLine("December to February");
            else if (s == Season.Summer)
                Console.WriteLine("June to August");
            else if (s == Season.Automn)
                Console.WriteLine("September to November");
            else if (s == Season.Spring)
                Console.WriteLine("March to May");
            else
                Console.WriteLine("Invalid Season");
        }
        static void Q3()
        {
            Permissions p1 = Permissions.read;
            Console.WriteLine(p1);
            Console.WriteLine((int)p1);

            // add delete
            p1 ^= Permissions.delete;
            Console.WriteLine(p1);
            Console.WriteLine((int)p1);

            // add write
            p1 |= Permissions.write;
            Console.WriteLine(p1);
            Console.WriteLine((int)p1);

            // remove delete
            p1 ^= Permissions.delete;
            Console.WriteLine(p1);
            Console.WriteLine((int)p1);

            //remove write
            p1 ^= Permissions.write;
            Console.WriteLine(p1);
            Console.WriteLine((int)p1);

            // add delete and write
            p1 = p1 | Permissions.write | Permissions.delete;
            Console.WriteLine(p1);
            Console.WriteLine((int)p1);

            //remove delete
            p1 &= ~Permissions.delete;
            Console.WriteLine(p1);
            Console.WriteLine((int)p1);

            //check read
            if ((p1 & Permissions.read) == Permissions.read)
                Console.WriteLine("Exist");
            else Console.WriteLine("NOT Exist");

            //check delete
            if ((p1 & Permissions.delete) == Permissions.delete)
                Console.WriteLine("Exist");
            else Console.WriteLine("NOT Exist");
        }
        static void Q4() 
        {
            try
            {
                Console.WriteLine("Enter Color: ");
                Color color = (Color)Enum.Parse(typeof(Color), Console.ReadLine(), true);
                if (color == Color.red || color == Color.green || color == Color.blue)
                    Console.WriteLine("primary color");
                else Console.WriteLine("Invalid");
            } catch (Exception e) {
                Console.WriteLine("NOT primary");
            }
        }
    }//class
}//namespace
