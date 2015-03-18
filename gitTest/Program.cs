using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gitTest
{
    //enumeration exp
    public enum TimeOfDay
    {
        morning = 0, 
        noon = 1,
        evening = 2
    }
    //enum ends here




    //class inhret
    class Fruit
    {
        string placeOfProduced;

        //construct function without any attribute
        public Fruit(){
            placeOfProduced = "USA";
            Console.WriteLine("Fruit constructed");
        }

        //construct funtion with attribute
        public Fruit(string _placeOfProduced)
        {
            placeOfProduced = _placeOfProduced;
            Console.WriteLine("Fruit constructed");
        }
    }

    class TropicalFruit : Fruit
    {
        //construct a base class first
        public TropicalFruit() { Console.WriteLine("TropicalFruit constructed"); 
        }

        //inhret construct function of base class using "base(_string)" to 
        public TropicalFruit(string _placeOfProduced)
            : base(_placeOfProduced)
        { }
    }
    //class inhret ends here

    

    class Program
    {
        static void Main(string[] args)
        {
            TropicalFruit tf = new TropicalFruit();

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
