using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace MorseCode.Nuget
{
    public class Morse : Morsecode, IMorse
    {
        private StringBuilder wordline = Factory.StringbuilderConstructor();
        private ISegregate _segregate = Factory.SegregateConstructor();
        public char ToAlphabet(string morse)
        {
            if (_segregate.MorseDataisValidated(morse))
            {
                List<Morsecode> morsecode = GetMorseData();
                foreach (var _morse in morsecode)
                {
                    if (_morse.Morse == morse)
                    {
                        return _morse.Alphabet;
                    }
                }

                return ' ';
            }
            else
            {
                throw new Exception("Input was not correct");
            }
        }
        public string ToWordLine(List<string> morse)
        {
            foreach (var alphabet in morse)
            {
                var character = ToAlphabet(alphabet);
                wordline.Append(character);
            }
            string output = wordline.ToString();
            return output;
        }

    }
}
