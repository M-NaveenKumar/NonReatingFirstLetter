using System;
using System.Linq;

namespace NonRepeatingChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Input String or Enter 'Exit' to exit");
            string inputString = Console.ReadLine();
            while (inputString.ToLower() != "exit")
            {
                int index = -1;
                char[] repeatingChar = new char[inputString.Length];
                int repeatCharInex = 0;
                for (int i = 0; i < inputString.Length; i++)
                {
                    if ( repeatingChar.Contains(inputString.ElementAt(i)) ||inputString.LastIndexOf(inputString.ElementAt(i)) > i)
                    {
                        repeatingChar[repeatCharInex] = inputString.ElementAt(i);
                        continue;
                    }
                    else
                    {
                        index = i;
                        break;
                    }
                }

                if (index > -1)
                    Console.WriteLine("Non Repeating letter index : " + index + " and letter " + inputString.ElementAt(index));
                else
                   Console.WriteLine("all repeat");
                Console.WriteLine("=========================\nEnter Input String or Enter 'Exit' to exit");
                 inputString = Console.ReadLine();
            }
            
        }
    }
}
