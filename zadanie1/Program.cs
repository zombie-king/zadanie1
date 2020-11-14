using System;
using CommandLine;

namespace zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Arguments>(args)
                .WithParsed<Arguments>(arguments =>
                {
                    var quadraticEquationRoots = new QuadraticEquationRoots(arguments.A, arguments.B, arguments.C);
                    var result = quadraticEquationRoots.Calculate();
                    Console.WriteLine(QuadraticEquationRoots.FormatResult(result));
                });
        }
    }
}
