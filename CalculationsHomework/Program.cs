using System;
using System.IO;
using System.Threading;

namespace CalculationsHomework
{
    class Program
    {
        public string SumOfNumbers(string num1, string num2)
        {
            string result = num1 + num2;
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to enter 2 numbers? Enter Y/N");
            string userInput = Console.ReadLine();
            string currentDirectory = Directory.GetCurrentDirectory();
            string line = "";

            for (int i = 0; i < 3; i++)
            {
                if (line != null)
                    Console.WriteLine(line);

                if (userInput == "Y")
                {
                    int num1 = 2;
                    int num2 = 3;
                    Console.WriteLine($"The sum of the numbers is {num1 + num2}");
                    int num3 = 4;
                    int num4 = 5;
                    Console.WriteLine($"The sum of the numbers is {num3 + num4}");
                    int num5 = 6;
                    int num6 = 7;
                    Console.WriteLine($"The sum of the numbers is {num5 + num6}");
                    Console.WriteLine("The sum of the numbers is 5,9 and 13");
                
                string folderPath = "../Exercise";
                string filePath = folderPath + @"\Calculations.txt";
                    for (int counter = 0; counter<3; counter++)
                    {
                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                            if (File.Exists(filePath))
                            {
                                File.AppendAllText(filePath, "The file was successffully created!");
                            }
                            try
                            {
                                using (StreamWriter sw = new StreamWriter(filePath))
                                {

                                    sw.WriteLine("The sum of the numbers is 5,9 and 13");
                                    Console.WriteLine($"{num1 + num2}");
                                    Console.WriteLine($"{num3 + num4}");
                                    Console.WriteLine($"{num5 + num6}");
                                    Thread.Sleep(3000);
                                }
                            }
                            catch(Exception ex)
                            {
                                Console.WriteLine($"{ex.Message}");
                            }
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
