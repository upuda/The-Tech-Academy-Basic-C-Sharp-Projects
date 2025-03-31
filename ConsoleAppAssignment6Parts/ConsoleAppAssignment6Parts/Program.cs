using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment Part 1
            //create a one-dimensional array
            string[] words = { "c#", "c++", "java", "python" };
            //askign user to input some text
            Console.Write("Enter the word which you want to append:");
            string input = Console.ReadLine();
            //Iterate through each string in the array, and append user's text with the array element
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = input + " " + words[i];
            }
            //Print each string in the array at a time
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            //Assignment 2
            //infinite Loop
            /*
            while (words.Length > 0)
            {
                //To print the statement
                Console.WriteLine("This is an infinite loop.");
            }*/
            //To fix the inifinite loop, I introduced a counter
            int counter = 0;
            while (counter < 5) //loop will exit after 5 iterations
            {
                Console.WriteLine("Loop iteration : " + (counter + 1));
                counter++;
            }
            Console.WriteLine("Loop has ended properly");

            //Assignment 3
            //Loop using '<' operator
            Console.WriteLine("Loop using '<' operator");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Iteration: " + (i + 1));
            }
            //Loop using '<=' operator
            Console.WriteLine("Loop using '<=' operator");
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Iteration: " + (i + 1));
            }

            //Assignment 4:
            //Creating a list whihc has unique items
            List<string> uniqueItems = new List<string> { "carrot", "cucumber", "broccoli", "tomato" };
            //To get the user input
            Console.WriteLine("Enter a text to search in the list: ");
            string searchInput = Console.ReadLine();
            bool itemFound = false;
            for (int i = 0; i < uniqueItems.Count; i++)
            {
                if (uniqueItems[i].Equals(searchInput))
                {
                    Console.WriteLine("The provided text is found in the index : " + i);
                    itemFound = true;
                    break;//to stop the loop once the match is found
                }
            }
            //if the searched input is not found
            if (!itemFound)
            {
                Console.WriteLine("The entered word is not present in the list");
            }

            //Assignment 5
            //List with identical strings in it
            List<string> secondList = new List<string> { "orange", "apple", "mango", "orange", "apple", "mango" };
            //Get the user input
            Console.WriteLine("Enter a text to search in the list (to get all the matching indices): ");
            string searchInput2 = Console.ReadLine();
            //List to save the index of the string, which is to be searched based on the user input
            List<int> matchingIndices = new List<int>();
            for (int i = 0; i < secondList.Count; i++)
            {
                if (secondList[i].Equals(searchInput2))
                {
                    matchingIndices.Add(i);//add the indices to the matchingindices list
                }
            }
            Console.WriteLine("The provided text is found in the below mentioned index/indices :");
            if (matchingIndices.Count > 0)
            {
                for (int i = 0; i < matchingIndices.Count; i++)
                {
                    Console.WriteLine(matchingIndices[i]);
                }
            }
            else
            {
                Console.WriteLine("The entered word is not present in the list");
            }

            //Assignment 6
            //create a list with identical strings in it
            List<string> stringWords = new List<string> { "apple", "strawberry", "mango", "apple", "orange", "mango" };

            //Iterate through the stringWords list
            for (int i = 0; i < stringWords.Count; i++)
            {
                string currentWord = stringWords[i];
                int number = 0;
                //to count how many times the word appears in the list
                for (int j = 0; j < stringWords.Count; j++)
                {
                    if (stringWords[j] == currentWord)
                    {
                        number++;
                    }
                }
                if (number > 1)
                {
                    Console.WriteLine(currentWord + " - this item is a duplicate");
                }
                else
                {
                    Console.WriteLine(currentWord + " - this item is unique");
                }
            }
            Console.ReadLine();
        }
    }

}
