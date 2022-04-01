using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Keywords
{
    internal class Variables
    {
        //Access Modifiers
        public int myPublicVariable;  // "public" is the least restrictive access modifier and means that
                                      // the variable/method/class can be accessed from anywhere including
                                      // other classes.

        internal int myInternalVariable;   // "internal" is an access modifier a bit more restrictive than public
                                           // meaning that the variable/method can only be used within the program
                                           // it is created. 

        protected int myProtectedVariable; // "protected" is more restrictive than public/interal, meaning that the 
                                           // variable/method/class can only accessed within the class and any
                                           // classes that inheirit this class.

        private int myPrivateVariable;     // "private" is very restrictive meaning that the variable/method 
                                           // can only be accessed within the body that it is declared.

        //Using Variables
        public void UsingVariables()
        {

        //Integers
        int myInteger = 1;
            // Integers are used to hold whole numbers and do basic math
            // operations.
            // Integers can be negative or positive, but cannot be used to
            // store decimals.

            //Double 
            double myDouble = 2.2;
            // The double datatype is more accurate allowing decimal places
            // to be used.
            // Therefore, they use more memory than a standard integer.

            //Float
            float myFloat = 5.124f;
            // Floats are similar to doubles as they allow decimal places,
            // however, the key difference is that the decimal place is not,
            // consistent and therefore should not be used for comparisons as
            // the number is constantly changing slightly.
            // Floats are declared using "f" after the number.

            //Strings
            string myString = "hello this is a sentence";
            // Strings are used to hold text more than one symbol long.
            // A string is defined by the quotation marks ("").

            // Strings in C# are their own class and therefore have various
            // methods that can be used.

            //Shows the number of characters in the string
            int length = myString.Length;

            int height = 185;
            string name = "John";

            // Here we can format the string to replace the placeholders with other datatypes
            string result = String.Format("{0} is {1}cm tall ", name, height);

            //Char
            char myChar = 'G';
            // Chars are single symbols and are single elements of a string.
            // characters are declared using '' to enclose the symbol.

            //Boolean
            bool myBoolean = false;
            // booleans can be seen as switches or flags, meaning they only have two states,
            // true or false. (on or off)
            // These are useful for controlling the logic of our program using statements.

        }
    }
}
