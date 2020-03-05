using System;

namespace Animals
{

     class Duck : Animal
    {
        public Duck(string lastName)
        {
            this.name = "El perro";
            this.lastName = lastName;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{this.name} le hace asi de: WUFF WUFF");
        }
    }
}