using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial
{
    class Animal
    {
        public virtual void SayHi()
        {
            Console.WriteLine("I'm an animal");
        }
    }

    class Cat : Animal
    {
        public override void SayHi()
        {
            Console.WriteLine("I'm a cat");
        }
    }

    class Dog : Animal
    {
        public override void SayHi()
        {
            Console.WriteLine("I'm a dog");
        }
    }
    class PolymorphismeExample
    {

        public void ShowExample()
        {

            Animal a = new Cat();
            Cat c = new Cat();
            Dog d = new Dog();

            a.SayHi();
            c.SayHi();
            ((Animal)d).SayHi();
        }
    }
}
