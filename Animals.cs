using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new Duck("con tenis");

            duck.MakeSound();
            Console.WriteLine(duck.GetFullName());

            
            
            //Console.WriteLine(duck.LastName);
            //duck.LastName = "casablanca bustamantes";
            //Console.WriteLine(duck.LastName);
            //Console.WriteLine(duck.GetFullName());

            
            
            Animal dog = new Dog ("chilakiller");
            Animal duck2 = new Duck ("Dodo Light");

            animal[] pets = new Animal[2];


        }
    }
}
