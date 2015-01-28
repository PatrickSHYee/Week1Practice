using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // DECLARING VARIABLES
            string myName = "Patrick Yee";
            int myAge = 31;
            bool myBool = false;
            List<string> productsList = new List<string>();

            productsList.Add("basketball");
            productsList.Add("baseball glove");
            productsList.Add("tennis shoes");
            productsList.Add("hockey puck");

            // PRINT THE VARIABLES USING CONSOLE.WRITELINE()
            Console.WriteLine("My name is {0} and I'm a beast of a programmer", myName);
            Console.WriteLine("I am {0} years awesome", myAge);
            Console.WriteLine("I set my boolean value equal to {0}", myBool);

            for (int i = 0; i < productsList.Count; i++)
            {
                Console.WriteLine(productsList[i]);
            }

            // FOR LOOP PRACTICE
            // prints out 1 - 10
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1);
            }
            // prints out 10 - 1
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            // prints out only the even numbers from 10 to 30
            for (int i = 10; i < 31; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            // prints out the numbers by 5 from 100 to 75
            for (int i = 100; i >= 75; i -= 5)
            {
                Console.WriteLine(i);
            }

            // WHILE LOOP PRACTICE
            int n = 0;  // this will be my counter for all my while loops.
            int endingNumber = 10;
            // prints out 1 - 10
            while (n < endingNumber)
            {
                Console.WriteLine(n + 1);
                n++;
            }
            // prints out 10 - 1
            n = 10;
            endingNumber = 0;
            while (n > endingNumber)
            {
                Console.WriteLine(n);
                n--;
            }
            // prints out the even numbers from 15 - 30
            n = 15;
            endingNumber = 30;
            while (n <= 30)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine(n);
                }
                n++;
            }
            // prints out every 5 numbers from 100 - 75
            n = 100;
            endingNumber = 75;
            while (n >= endingNumber)
            {
                Console.WriteLine(n);
                n = n - 5;
            }
            // prints out the first number that is divisible by 4 of 1 - 10
            n = 1;
            endingNumber = 10;
            while (n % 4 != 0) { 
                n++;
            }
            Console.WriteLine(n);

            // PUTTING IT ALL TOGETHER: use either a for or while loop
            // prints out number of letters in myName variable
            int numberOfLetters = 0;
            for (n = 0; n < myName.Length; n++)
            {
                numberOfLetters++;
            }
            Console.WriteLine("My name, {0}, has {1} in it.", myName, numberOfLetters);
            // prints out the number of items in the productsList variable
            n = 0;
            while (n < productsList.Count)
            {
                n++;
            }
            Console.WriteLine("My product list has {0} in it.", n);
            // prints out the number of letters for each item in the productsList variable
            for (n = 0; n < productsList.Count; n++)
            {
                numberOfLetters = 0;

                string item = productsList[n];
                while (numberOfLetters < item.Length)
                {
                    numberOfLetters++;
                }
                Console.WriteLine("{0} has {1} in it.", item, numberOfLetters);
            }

            // DECLARING AND CALLING FUNCTIONS
            Greeting("Geronimo Jackson");
            Greeting(myName);
            DoubleIt(1337);
            DoubleIt(myAge);
            Multiply(2, 8);
            Multiply(3, myAge);
            LoopThis(20, 30);
            LoopThis(0, myAge);

            // debugger stopper
            Console.WriteLine("Any key to continue...");
            Console.ReadKey();
        }

        /// <summary>
        /// Prints out a hello greeting.
        /// </summary>
        /// <param name="name">Input from the program</param>
        static void Greeting(string name)
        {
            Console.WriteLine("Hello {0}", name);
        }

        /// <summary>
        /// It takes a number as input and prints out the double
        /// </summary>
        /// <param name="number">the input number</param>
        static void DoubleIt(int number)
        {
            Console.WriteLine("{0} doubled is {1}", number, number * 2);
        }

        /// <summary>
        /// Takes two numbers and multiply them
        /// </summary>
        /// <param name="num1">input of a integer</param>
        /// <param name="num2">another input of a integer</param>
        static void Multiply(int num1, int num2)
        {
            Console.WriteLine("{0} times {1} is {2}", num1, num2, num1 * num2);
        }

        /// <summary>
        /// Takes two numbers and prints what it is doing and prints out the numbers from start to end.
        /// </summary>
        /// <param name="startNum">Starting input number</param>
        /// <param name="endNum">Ending input number</param>
        static void LoopThis(int startNum, int endNum)
        {
            Console.WriteLine("I'm looping from {0} to {1}", startNum, endNum);
            while (startNum <= endNum)
            {
                Console.WriteLine(startNum);
                startNum++;
            }
        }

        static void SuperLoop(int startNum, int endNum, int increment)
        {
            int loopCount = 0;

            while (startNum < endNum)
            {

            }
        }
    }
}
