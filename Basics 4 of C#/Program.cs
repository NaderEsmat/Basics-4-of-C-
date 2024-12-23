using System.Drawing;
using System.Reflection;
using System.Text;

namespace Basics_4_of_C_
{

    enum WeekDays : byte
    {
       
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday ,
        Saturday,
        Sunday
    }

    enum seasons
    {
        Spring = 1 , 
        Summer = 2 , 
        Autumn = 3 , 
        Winter = 4 ,
        w = 4 ,
        a = 3 ,
        sum = 2 , 
        spr = 1
         
    }

    enum Colors : byte
    {
        Red = 1 ,
        r = 1,
        Green = 2 ,
        g = 2 ,
        Blue = 3 , 
        b = 3 ,
    }
    [Flags]
    enum permissions
    {
        Read = 8,
        Write = 4,
        Execute = 2,
        Delete = 1
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            // Part 1 
            // Done in Demo 


            // Part 2 
            #region Question 1

            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion

            #region Question 2

            //Console.WriteLine("Enter Season Name : ");

            //seasons s1;
            //Enum.TryParse(typeof(seasons), Console.ReadLine() , true , out object s);

            //s1 = (seasons) s;

            //Console.WriteLine(s1);

            //switch (s1)
            //{
            //    case seasons.Autumn:
            //        Console.WriteLine("September to November");
            //        break;

            //    case seasons.Winter:
            //        Console.WriteLine("December to February");
            //        break;
            //    case seasons.Summer:
            //        Console.WriteLine("June to August");
            //        break;
            //    case seasons.Spring:
            //        Console.WriteLine("March to May");
            //        break;

            //}

            #endregion

            #region Question 3

            permissions p1 = permissions.Read;

            p1 ^= permissions.Execute;

            p1 ^= permissions.Execute; 

            Console.WriteLine(p1);

            if ((p1 & permissions.Execute) == permissions.Execute)
            {
                Console.WriteLine("Exists");
            }
            else
            {
                Console.WriteLine("Not Exists");
            }



            #endregion

            #region Question 4


            //Console.WriteLine("Enter Color");

            //bool Flag;

            //Colors c1;

            //Flag = Enum.TryParse( typeof(Colors),Console.ReadLine(), true, out object c);



            //if (Flag && c != null)
            //{
            //    c1 = (Colors)c;

            //    Console.WriteLine("Primary");
            //}
            //else
            //{
            //    Console.WriteLine("Not Primary");
            //}

            #endregion


        }

    }
}

