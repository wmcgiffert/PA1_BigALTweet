using System;
using System.Collections.Generic;
using System.IO;

namespace PA_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Post> tweet = PostFile.GetPosts();
            Console.WriteLine("Welcome to Big Al's Post");
            Menu();

        }
         static void Menu()
        {
            bool exit = false;


            while (exit == false)
            {
                //Menu selections
                Console.WriteLine("Please Select: \n" +
                    "[1] Show all Post \n" +
                    "[2] Add Post \n" +
                    "[3] Delete Post by ID\n" +
                    "[4] Exit \n");
                string userSelection = Console.ReadLine();
                int selection = 0;

                //Error checking loop that only accepts numbers
                bool valid = int.TryParse(userSelection, out selection);
                while ((valid == false) || (!(selection == 1 || selection == 2 || selection == 3 || selection == 4)))
                {
                    Console.WriteLine("Error Please enter a valid selection");

                    userSelection = Console.ReadLine();
                    valid = int.TryParse(userSelection, out selection);
                }

                //Menu logic options 
                if (selection == 1)
                {
                    Console.WriteLine("Show All Post");
                    // ShowAllPost();
                }
                else if (selection == 2)
                {
                    Console.WriteLine("Add Post");
                    // AddPost();
                }
                else if (selection == 3)
                {
                    Console.WriteLine("Delete Post");
                    // DeletePost();
                }
                else if (selection == 4)
                {
                    exit = true;
                    Console.WriteLine("Thank you. Have a nice day!");
                }

                
            }

        }
    }
}
