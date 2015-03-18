using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gitTest
{
    //enum AllList
    public enum TimeOfDay
    {
        morning = 0, 
        noon = 1,
        evening = 2
    }
    //enum ends here


    //class inhret

    //class inhret ends here

    

    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {1,2,3,4 };
            foreach (int i in a)
                //usage of 'foreach'
                Console.WriteLine(i);

            greeting(TimeOfDay.noon);
            Console.WriteLine("{0}", TimeOfDay.morning);
        }

        static void greeting(TimeOfDay timeOfDay)
        {
            switch (timeOfDay)
            {
                case 0:
                    Console.WriteLine("good morning");
                    break;
                case TimeOfDay.noon:
                    Console.WriteLine("GOOd noon");
                    break;
                case TimeOfDay.evening:
                    Console.WriteLine("GOOd evening");
                    break;
                default:
                    Console.WriteLine("hello");
                    break;
            }
        }
    }
}
