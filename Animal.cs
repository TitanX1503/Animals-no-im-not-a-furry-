using System;

namespace Animals
{

     abstract class Animal
    {
        protected string name;

        protected string lastName;

        public string LastName 
        {get => $"ES SEÑOR {lastName} PARA TU NACO!";
         set => lastName = value;
        }

        public abstract void MakeSound();

        public string GetFullName()
        {
            return $"{this.name} {this.lastName}";
        }
    }
}