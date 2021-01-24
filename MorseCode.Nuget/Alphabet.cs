using System;
using System.Collections.Generic;
using System.Text;


namespace MorseCode.Nuget
{
    public class Alphabet : Morsecode, IAlphabet
    {
        private StringBuilder _morsecode = Factory.StringbuilderConstructor();
        public string ToMorse(char alphabet)
        {
            char.ToUpper(alphabet);
            List<Morsecode> morseData = GetMorseData();
            foreach (var _alphabet in morseData)
            {
                if (_alphabet.Alphabet == alphabet)
                {
                    return _alphabet.Morse;
                }
            }
            return " ";   
        }
        public string ToMorsecode(string words)
        {
            string _words=words.ToUpper();

            for (int i = 0; i < _words.Length; i++)
            {
                string morsecode = ToMorse(_words[i]);
                _morsecode.Append(morsecode + " ");
            }
            return _morsecode.ToString();
        }
    }
}
