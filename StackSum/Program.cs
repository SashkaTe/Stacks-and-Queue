using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var stack = new Stack<int>();
            foreach (var item in input)
            {
                stack.Push(item);
            }

            var command = Console.ReadLine().ToLower();
            
            while (command !="end")
            {
                var splitedCommand = command.Split(' ').ToList();
              
                if (splitedCommand[0]=="add")
                {
                    var first = int.Parse(splitedCommand[1]);
                    var second = int.Parse(splitedCommand[2]);

                    stack.Push(first);
                    stack.Push(second);
                }

                if (splitedCommand[0] == "remove")
                {
                    var n=int.Parse(splitedCommand[1]);

                    if (n <= stack.Count)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                command = Console.ReadLine().ToLower();
            }
            Console.WriteLine("Sum: {0}",stack.Sum());

        }
    }
}
