using Encryption.CaesarCipher.Abstracts;
using Encryption.CaesarCipher.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption.CaesarCipher.Services
{
    public class SpanStringShifter : StringShifterValidator, IStringShifter
    {
        private readonly int _shift;
        private readonly string _input;
        public SpanStringShifter(int shift, string input) : base(input)
        {
            _shift = shift;
            _input = input;
        }
        public string Shift()
        {
            return string.Create(_input.Length, _input, (span, value) =>
            {
                value.AsSpan().CopyTo(span);
                for (int i = 0; i < span.Length; i++)
                {
                    int shifted = _input[i] + _shift;

                    if (shifted > 90)
                    {
                        shifted = 65 + shifted - 91;
                    }
                    span[i] = (char)shifted;
                }
            });
        }
    }
}
