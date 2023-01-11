using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input=Console.ReadLine();
            var stack= new Stack<int>();

            for (int i = 0; i < input.Length-1; i++)
            {
                if (input[i]=='(')
                {
                    stack.Push(i);  
                   
                }
                if (input[i]==')')
                {
                  int openBracket= stack.Pop();

                    for (int j = openBracket+1; j < i; j++)
                    {
                        Console.Write(input[j]);
                    }
                    Console.WriteLine();
                }
                {

                }
            }

        }
    }
}
