using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMEWORK_1
{

    class program
    {
        static void Main(string[] arg)
        {
            Console.Title = "HOMEWORK 1";
            Console.WriteLine("enter message to encode");
            string message = Console.ReadLine();

            char[] characters = new char[message.Length + 1];

            for (int i = 0; i < message.Length; i++)
                characters[i] = message[i];

            int charCount = 1;

            for (int j = 0; j < characters.Length - 1; j++)
            {
                try
                {
                    if (characters[j] == characters[j + 1])
                    {
                        charCount += 1;
                    }
                    else
                    {
                        Console.Write("{0}{1}", charCount, characters[j + 1]);

                        charCount = 1;
                    }
                }
                catch (IndexOutOfRangeException exp)
                {
                    Console.WriteLine();
                    Console.WriteLine("array index out of ound!");
                    Console.WriteLine(exp.StackTrace);
                }
            }

            Console.ReadLine();

        }
    }
}
