// This adds the "System" namespace to the project so that we can use all
// the functionality it has such as Console to write a message
using System;
using CSharp_Keywords;

namespace CSharp_Keywords // This is the default namespace for the project (same as the project name)
{                         // Any class created in this project will have this namespace assigned to it
    class Program // This is a class that has been automatically generated for our project.
    {             // Classes are templates used in programming to create objects by defining
                  // their actions and attributes.
                  // Below is the base implementation when the project was created.
        static void Main(string[] args) // "static" is a keyword which means that whatever class,
        {                               // method or variable with this keyword does not need to
                                        // have an instance created, and therefore only one version
                                        // can exist within the program.

                                        // "void" means that the the method does not return any value

                                        // "Main" is the entry point for our program and is the name of
                                        // the method. Main is always declared as static as it is the
                                        // entry point for our program, therefore only one entry point
                                        // can exist

                                        // "string" is a datatype within C# and is common among various
                                        // programming languages. here, the Main method takes an array
                                        // of strings as arguments for when the program starts. 

            Console.WriteLine("Hello World!"); // "Console" refers to the window that is created when
                                               // the program is started. 
                                               // "WriteLine" is a method which is part of the Console
                                               // namespace, which writes a string specified to the 
                                               // Console window.
                                               // "Hello World" is a string passed into the WriteLine
                                               // method.

        }
    }
}