using BenchmarkDotNet.Attributes;
using Encryption.CaesarCipher.Interfaces;
using Encryption.CaesarCipher.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption.CaesarCipher
{

    // To run this benchmark switch to Release mode and run without debugging
    [MemoryDiagnoser]
    public class Benchmarker
    {
        [Benchmark]
        public string BasicStringShift()
        {
            IStringShifter shifter = new BasicStringShifter(5);
            var result = shifter.Shift("HELLOFROMTHEOTHERSIDE");
            return result;
        }
        [Benchmark]
        public string ReadOnlySpanStringShift()
        {
            IStringShifter shifter = new SpanStringShifter(5);
            var result = shifter.Shift("HELLOFROMTHEOTHERSIDE");
            return result;
        }
        [Benchmark]
        public string StringBuilderStringShift()
        {
            IStringShifter shifter = new StringBuilderStringShifter(5);
            var result = shifter.Shift("HELLOFROMTHEOTHERSIDE");
            return result;
        }
    }
}
