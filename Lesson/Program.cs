using System;
using System.Numerics;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Write a string of numbers and letters \n");
            string numbers = Console.ReadLine();
            Console.WriteLine();

            long total = 0;
            

            for (int i = 0; i < numbers.Length; i++)
            {
                
                if (Char.IsDigit(numbers[i]))
                {
                    for (int j = i + 1; j < numbers.Length; j++)
                    {
                        string before = numbers.Substring(0, i);
                        string marked = numbers.Substring(i, j - i + 1);
                        string after = numbers.Substring(j + 1, numbers.Length - j - 1);
                        

                        if (Char.IsLetter(numbers[j]))
                        {
                            break;
                        }

                        if (numbers[j] == numbers[i])
                        {
                            Console.Write(before);

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(marked);

                            Console.ResetColor();
                            Console.WriteLine(after);


                            try
                            {
                                total += long.Parse(marked);
                            }
                            catch
                            {
                                Console.WriteLine("Current string is too long");
                                break;
                            }

                            if (marked.Contains(marked[0]))
                            {
                                break;
                            }
                            
                        }
                        
                    }

                }   

            }
            
            
            Console.WriteLine($"\n Marked strings summarized: {total}");

            Console.ReadKey();
        }
        
    }
}
    

