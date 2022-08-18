using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Encryption.CaesarCipher.Interfaces;
using Encryption.CaesarCipher.Services;
using System;
namespace Encryption.CaesarCipher
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int shift = 5;
            string output = "";
            Console.Write("Input: ");
            string input = Console.ReadLine();
            if (input != null)
            {
                IStringShifter shifter = new SpanStringShifter(shift);
                output = shifter.Shift(input);
            }
            Console.WriteLine("Output: " + output);

            // Benchmark to check which implementation gives best performance
            //BenchmarkRunner.Run<Benchmarker>();
        }
    }
}