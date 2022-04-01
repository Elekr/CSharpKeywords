using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Keywords
{
    //Classes
    // Classes are a template which is used as the building blocks to creating an object-oriented program.
    // Classes are declared by stating the access modifier, (access modifiers described more in variables class)
    // and the name signature of the class. Classes do not have input variables, as they are declared slightly differently
    internal class Classes
    {
        //Constructors
        // Constructors are way of passing variables into the class when they are declared.
        // This creates a contract when the class is created in memory that it requires a value to be 
        // passed in.
        Classes(int myValue)
        {
            value = myValue;
        }
        int value;

        public void Read()
        {
            
        }

        public void CreatingObjects()
        {
            //New
            // The new keyword is used to signify to the compiler that new memory needs to be 
            // allocated to heap in order to store the class as an object.
            // This allows us to use the object and call the methods and access variables stored within.

            //This will use the Dog class' inplementation of the sound method
            Animal animal = new Dog();
            animal.Sound();

            //This will use the Cat class' inplementation of the sound method
            Animal animal2 = new Cat();
            animal2.Sound(); 
        }
    }

    //Polymorphism
    // Polymorphism is the idea that objects share attributes, therefore, we can build upon different
    // classes inheiriting their variables and methods to expand on the implementation.
    // This is done by adding : "baseClassName"
    public class Animal
    {
        string name;
        int age;

        public void Sound()
        {

        }
    }

    public class Dog : Animal
    {
        public void Sound()
        {
            Console.WriteLine("bark");
        }
    }

    public class Cat : Animal
    {
        public void Sound()
        {
            Console.WriteLine("meow");
        }
    }

    //Interface
    // Interfaces are templates that designate specific methods. 
    // These methods can have an implementation in the body unlike abstract classes.
    // The key purpose of an interface is to create a contract with any class that inheirits
    // the interface that the methods within the interface must be declared and given an implementation
    // in the child class.

    public interface myMenu
    {
        void Play();
        void Stop();

    }

    //Abstract
    // An abtract class means that the class cannot be implemented or declared as an object,
    // therefore none of the variables or methods within the class can be created or accessed.
    // An abstract class is designed to be inheirited by another class to build upon the methods
    // declared in the abstract base implementation.
    public abstract class Car
    {
        public abstract void Drive();

        public abstract void Sound();
    }
}
