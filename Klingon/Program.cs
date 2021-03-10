using System;
using System.Collections.Generic;

namespace Klingon
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\..\Texts\textB.txt";

            string [] text = System.IO.File.ReadAllText(path).ToLower().Trim().Split(" ");
        // ============== Preposições ==============
            string [] prepo = Array.FindAll(text, element => element.Length == 3 && 
            !element.Contains("d") &&
            !element.EndsWith("s") &&
            !element.EndsWith("l") &&
            !element.EndsWith("f") &&
            !element.EndsWith("w") &&
            !element.EndsWith("k"));

            Console.WriteLine($"Preposições: {prepo.Length}");

            // ============== Verbos ==============
            string [] allVerbs = Array.FindAll(text, element => element.Length >= 8 &&
            element.EndsWith("s") ||
            element.EndsWith("l") ||
            element.EndsWith("f") ||
            element.EndsWith("w") ||
            element.EndsWith("k"));

            string[] firstPersonVerbs = Array.FindAll(allVerbs, element => !element.StartsWith("s") &&
            !element.StartsWith("l") &&
            !element.StartsWith("f") &&
            !element.StartsWith("w") &&
            !element.StartsWith("k"));

            Console.WriteLine($"Total de verbos: {allVerbs.Length}");
            Console.WriteLine($"Verbos em primeira pessoa: {firstPersonVerbs.Length}");
        }
    }
}
