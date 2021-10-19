using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Cat");
            cat.ShowInfo();
            Console.WriteLine();
            Dog dog = new Dog("Dog");
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        public abstract string Name { get; set; }
        public abstract void Say();

        public Animal(string name="Cat")
        {
            Name = name;
        }
        public void ShowInfo()
        {
            Console.Write($"{Name} ");
            Say();
        }
    }
    class Cat : Animal
    {
        string name;
        public Cat(string name) : base(name)
        {

        }
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public override void Say()
        {
            Console.Write(" Мяу ");
        }
    }
    class Dog : Animal
    {
        string name;
        public Dog(string Name) : base(Name)
        {

        }
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override void Say()
        {
            Console.Write(" Гав ");
        }
    }
}
