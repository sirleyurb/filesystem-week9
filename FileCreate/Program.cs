using System;
using System.IO; 

namespace FileCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples\wishList";
            Console.WriteLine("enter file name:");
            string fileName = Console.ReadLine();
            string fullfilePath = $@"{rootDirectory}\{fileName}.txt";

            bool directoryExists = Directory.Exists(rootDirectory);
            bool fileExists = File.Exists(fullfilePath);

            if (directoryExists && fileExists)
            {
                Console.WriteLine($"File {fileName} already exists in {rootDirectory}");
            }
            else if (!directoryExists)
            {
                Console.WriteLine($"wishlist directory does not exist.");
                Directory.CreateDirectory(rootDirectory);
                File.Create(fullfilePath);
                Console.WriteLine($"File {fileName}.txt has been created.");
            }
            else
            {
                File.Create(fullfilePath);
                Console.WriteLine($"File {fileName}.txt has been created.");
            }
           
            
            
        }
    }
}
