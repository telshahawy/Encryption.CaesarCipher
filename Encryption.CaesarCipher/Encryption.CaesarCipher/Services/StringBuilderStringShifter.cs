using Encryption.CaesarCipher.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption.CaesarCipher.Services
{
    public class StringBuilderStringShifter : IStringShifter
    {
        private readonly int _shift;
        public StringBuilderStringShifter(int shift)
        {
            _shift = shift;
        }
        public string Shift(string input)
        {
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < 65 || input[i] > 90)
                {
                    throw new Exception("Only A-Z supported.");
                }
                int shifted = input[i] + _shift;

                if (shifted > 90)
                {
                    shifted = 65 + shifted - 91;
                }
                output.Append((char)shifted);
            }
            return output.ToString();
        }
    }
}
