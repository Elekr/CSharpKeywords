using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Keywords
{
    internal class Loops
    {
        //Loops
        // Loops are a scope of code that is defined to execute for a defined number of times
        // or until a condition is met.

        //For
        // For loops have 3 main components to their declaration. A variable that used to indicate the start
        // point of the loop, a range that indicates how many iterations the loop will last, and how the starting
        // variable will be modified to reach the end of the range.

        public void myForLoop()
        { 
            for (int i = 0;/*Starting variable*/ i < 2; /*Range*/ i++ /*Incrememnt/Decrement*/)
            {

            }
        }

        //Foreach
        // The foreach loop is also refered to as an enhanced for loop, the loop goes through all the
        // values within a container.

        public void myForeachLoop()
        {
            int[] myArray = new int[5];
            foreach (int i in myArray)
            {
                Console.WriteLine(i);
            }
        }
        
        //While
        // While Loops execute the scope of code until a certain boolean condition is met.
        public void myWhileLoop()
        {
            bool loopCondition = true;
            int number = 5;
            while (loopCondition)
            {
                number--; // Decrement the loop by one
                if (number == 0)
                {
                    loopCondition = false; // Because the condition is now false, the loop will stop
                }
            }
        }

        //Do-While
        // The Do-while loop is similar to the while loop, however, the loop will always run at least once.

        public void myDoWhileLoop()
        {
            bool myCondition = true;
            do
            {
                myCondition = false;
            }
            while(myCondition);
        }
    }
}
