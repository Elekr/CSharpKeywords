using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Keywords
{
    internal class Statements
    {
        public void UsingStatements()
        {
            //Statements
            // Statements are a way of controlling the direction that the program progresses.
            // This is done through assessing if a value is true or false to dictate the path of the
            // program.

            //If
            // If statements are the most common type of statement and perform their body of scope if 
            // the statement is true, otherwise, it will just ignore the code and skip over it.
            if(true)
            {
                //Execute this code
            }

            //Else
            // Else statements are used along with if statements to provide another path for the code
            // to go through in the case that the if statement evaluates to false.
            if(true)
            {

            }
            else // if the above evaluation is false
            {

            }

            //Else If
            // Else if is a method of chaining if statements more elegantly, meaning that in the case that,
            // the if statement evaluates to false, perform another evaluation to attempt to run this body of code.
            // If the original statement is true, this evaluation is ignored.
            bool myCondition = false;
            if(myCondition)
            {

            }
            else if(!myCondition)
            {

            }

            //Switch
            // The switch statement performs the same action as a group of if statements,
            // however provides a more elegant implementation as well as reducing the number
            // of comparisons needed.
            // The statement takes a variable and compares the value against variable different
            // potential values, if the values match, that body of code is executed.
            // The break keyword signals to the compiler to break out of the current body of code
            int myValue = 7;
            switch(myValue)
            {
                case 0: // Value that is being compared to the input
                    //Will not execute because this is not 7
                    break;

                case 7:
                    //Will execute because the values are the same.
                    break;

                    default:
                    //This body of code will only execute if none of the values match
                    break;
            }
        }
    }
}
