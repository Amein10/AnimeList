/*
 The keyword "using" is something which allow us to use something and the thing we want to use is "System".
 System is a namespace and a container for classes and namespaces. 
 * 
 The s
 * Contains interfaces and classes that define generic collections, which allow users to create strongly typed collections that provide better type safety and performance than non-generic strongly typed collections.
 */
using System;
using System.Collections.Generic;

namespace AnimeList
{
    class AnimeList
    {
        static void Main(string[] args)
        {
            // Creating a new single-dimensional array of anime objects
            Anime[] animeArray = new Anime[3];
            animeArray[0] = new Anime("Naruto", "Action", new DateTime(2002, 10, 3), "The story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.");
            animeArray[1] = new Anime("One Piece", "Adventure", new DateTime(1999, 10, 20), "Monkey D. Luffy sets out to find the legendary One Piece treasure and become the Pirate King.");
            animeArray[2] = new Anime("Dragon Ball Z", "Action", new DateTime(1989, 4, 26), "The adventures of adult Goku and his friends as they defend the Earth against powerful villains and battle to protect the Dragon Balls.");

            // Displaying a list of anime titles
            Console.WriteLine("My Anime List:");
            DisplayAnimeArray(animeArray);

            // Add a new anime object to the list
            Console.WriteLine("Enter a new anime title:");
            string newTitle = Console.ReadLine();
            Console.WriteLine("Enter the genre of the anime:");
            string newGenre = Console.ReadLine();
            Console.WriteLine("Enter the release date of the anime (mm/dd/yyyy):");
            DateTime newReleaseDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter a summary of the anime:");
            string newSummary = Console.ReadLine();

            Anime newAnime = new Anime(newTitle, newGenre, newReleaseDate, newSummary);
            int newIndex = AddAnimeToArray(animeArray, newAnime);
            if (newIndex == -1)
            {
                Console.WriteLine("Array is full, cannot add new anime.");
            }
            else
            {
                Console.WriteLine("New anime added at index " + newIndex);
            }

            // Displaying the updated list of anime objects
            Console.WriteLine("\nMy Updated Anime List:");
            DisplayAnimeArray(animeArray);
            Console.ReadKey();
        }

        // Method to display the anime array
        static void DisplayAnimeArray(Anime[] animeArray)
        {
            for (int i = 0; i < animeArray.Length; i++)
            {
                if (animeArray[i] != null)
                {
                    Console.WriteLine("Title: " + animeArray[i].Title);
                    Console.WriteLine("Genre: " + animeArray[i].Genre);
                    Console.WriteLine("Release Date: " + animeArray[i].ReleaseDate.ToShortDateString());
                    Console.WriteLine("Summary: " + animeArray[i].Synopsis);
                    Console.WriteLine();
                }
            }
        }

        // Method to add a new anime to the array
        static int AddAnimeToArray(Anime[] animeArray, Anime newAnime)
        {
            for (int i = 0; i < animeArray.Length; i++)
            {
                if (animeArray[i] == null)
                {
                    animeArray[i] = newAnime;
                    return i;
                }
            }
            return -1;
        }
    }

}