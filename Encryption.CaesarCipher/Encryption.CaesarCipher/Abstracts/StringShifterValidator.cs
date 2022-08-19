using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption.CaesarCipher.Abstracts
{
    public abstract class StringShifterValidator
    {
        public StringShifterValidator(string str)
        {
            Validate(str);
        }

        private void Validate(string str)
        {
            if (str.Any(c => c < 65 || c > 90))
                throw new Exception("Only A-Z supported.");
        }
    }
}
