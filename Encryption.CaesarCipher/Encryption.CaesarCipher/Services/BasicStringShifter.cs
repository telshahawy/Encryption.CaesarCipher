using Encryption.CaesarCipher.Abstracts;
using Encryption.CaesarCipher.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption.CaesarCipher.Services
{
    public class BasicStringShifter : StringShifterValidator, IStringShifter
    {
        private readonly int _shift;
        private readonly string _input;
        public BasicStringShifter(int shift, string input) : base(input)
        {
            _shift = shift;
            _input = input;
        }
        public string Shift()
        {
            var output = "";
            for (int i = 0; i < _input.Length; i++)
            {
                int shifted = _input[i] + _shift;
                if (shifted > 90)
                {
                    shifted = 65 + shifted - 91;
                }
                output = output + (char)shifted;
            }
            return output;
        }
    }
}
