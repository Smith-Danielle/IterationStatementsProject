using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
                //TODO - Read each comment and complete its instruction
                // like the example below

                //Create a List called "numbers" - DONE!
                var numbers = new List<int>();

            //-----START HERE------------------------------------------
            //Create a variable of type int and name it num - done
            int num;
            //initialize the variable with a value of 0 - done

            num = 0;

            // Create a do-while loop and use the template below: - done
            // This is adding numbers less than 100 to the list, 1-100.
            // The num value is constantly being changed(incremented) during the do loop, all the way to 100 & added to the list.
            do
            {
                // Increment num by 1 - done
                num++;
                // Then add num to the collection - numbers - done
                // Hint: reference num inside of the Add method's parentheses
                numbers.Add(num/* num */);

            } while (num < 100);// <---- While your variable is less than 100 - done



            // Create a while loop
            // This portion changes(increments) the value of num from 101 to 200 and adds to list.
            while (num < 200) // <--- While num is less than 200 - done
            {
                // Increment num by 1 - done
                num++;
                // Then add num to the collection numbers - done
                //HINT: copy how this was done in the do while loop
                numbers.Add(num);

            }


            // This is to show the user that the numbers will start increasing on the console
            // 1-200(list numbers) will be counted to console.
            Console.WriteLine("Increase:");


            // Create a foreach loop using the collection - numbers - done
                //In the scope of the foreach loop, print each number in numbers -done
            foreach (var userNum in numbers)
            {
                Console.WriteLine($"{userNum}");
            }
             


            Console.WriteLine("");// prints empty line
            Console.WriteLine("Decrease:");


            // Create a for loop - this will print the numbers in reverse order - from 200 to 1
            // in your initializer set the value of i to 199
            // this allows us to count down from 200
            // in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count)
            // numbers is the list name. so we count items inside the numbers list. but this first condition doesnt have to be there since we start the index at 199 anyway.
            // AND as long as i is greater than or equal to 0
            // i references the index, from which we get the value. i is 199, which the value is 200
            // Decrement i by 1

            //start for loop here
            for (int i = 199; i <= numbers.Count && i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);// place numbers[i] inside of the Console.WriteLine() method
                // will print the list and index i, the i will decrease each time its ran, indexing each position downward.
                // index is telling the computer at what position do you want to do to get the value.
            }

            //------------End of exercise
        }
    }
}
