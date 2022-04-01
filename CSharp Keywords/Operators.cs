using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Keywords
{
    internal class Operators
    {
        //Using Operators
        public void UsingOperators()
        {
            //"=" operator
            int assignment = 1;
            // This operator is used to assign data to variables.

            //"==" operator
            if(assignment == 1)
            {
                Console.WriteLine("hello!");
            }
            // This operator is used to compared two different datatypes to see if they are the same.
            // It compares the values of the held by the variables instead of where the variables are stored.

            //"<" and ">" operator
            if (assignment > 0)
            {
                Console.WriteLine("Greater than");
            }
            else if (assignment < 2)
            {
                Console.WriteLine("Less than");
            }
            // The < and > are used to check if a variable is greater or less than another.
            // This operator can be combined with the = operator (<= and >=) to check if 
            // a variable is greater/less than or equal to another.

            //"!" operator
            bool myBoolean = false;
            if (!myBoolean)
            {
                Console.WriteLine("Not true");
            }
            else
            {
                Console.WriteLine("True");
            }
            // The ! operator means not, therefore changing a true value to false, and vice versa.

            //"&" operator
            int myInt1 = 1;
            int myInt2 = 2;
            if ((myInt1 & myInt2) >= assignment)
            {
                Console.WriteLine("Greater than or equal to");
            }
            // The & operator performs the evaluation even if the left hand side of the expression is false.


            //"|" operator
            if ((myInt1 | myInt2) >= assignment)
            {
                Console.WriteLine("Greater than or equal to");
            }
            // The | operator checks to see if either side of the expression is true. if neither are true it 
            // evaluates the statement to false.

            //++ and --
            assignment++;
            assignment--;

            //The ++ operator increments the variable by 1 whereas the -- operator decrements by 1
        }
    }
}
