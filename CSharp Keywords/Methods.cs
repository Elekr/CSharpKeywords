using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Keywords
{
    class Methods
    {
        //Methods
        // Methods have 5 main components to declaration, the access modifier, return type,
        // Signature, body, and input variables.
        public void myMethod(double data)
        {

        }

        //Access Modifier
        // The access modifier dictates where the method can be accessed.
        // The different access modifiers are public/protected/internal/private
        // Access modifiers are discussed in more detail in the variables class

        //Return Type
        public Methods method()
        {
            Methods method = new Methods();
            return method;
        }
        // The return type signifies what the method returns when the method is finished.
        // This is useful to store data from the function call within a variable
        // The method can return any datatype that has been declared, such as integers, strings
        // and even classes as shown above.

        //Method Signature
        // The method signature is the name of the method.
        // Methods usually follow the convention of an action followed by the item that the action
        // is being performed on. For example GetData, AddInteger

        //Input variables
        public void inputMethod(string name, int age)
        {
            Console.WriteLine(name + age.ToString());
        }
        // Input variables are data that you pass over to a method, this allows you to use the
        // variables for calculations.
        // Note that any changes made to this variable are only available within the scope of the method.
        // This is because the values are passed by value only, so only the data within the variable is passed over.
        // Changing the variable through the method is possible by using the keyword ref to create reference
        // to where the variable is being stored.

        //Method body
        // The method body is the scope of the method where data can be manipulated.
        // any variables declared in this area are only usable within the scope of the curly brackets. "{}"

        //Overloading
        public void myMethod(String name)
        {

        }
        // Overloading a method is done by keeping the same signature name but changing the parameters of the method.
        // For example, the myMethod method has been overloaded to take a string parameter instead.
        // This is useful to keep the same logic of the method while changing the parameters.


    }

    abstract class abstractMethod
    {
        //Abstract classes
        abstract public void myAbstractMethod();

        // Abstract methods are declared with the keyword abstract, this means that the method cannot 
        // be invoked or called upon. The use of abstract is to create a contract between this class and any classes
        // that implement this class that they use this method.
    }
}
