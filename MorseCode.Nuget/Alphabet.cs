using System;
using System.Collections.Generic;
using System.Text;

namespace MorseCode.Nuget
{
    public class Alphabet:Morsecode
    {
        private StringBuilder _morsecode = Factory.StringbuilderConstructor();
        public string ToMorse(char alphabet)
        {
            List<Morsecode> morseData = GetMorseData();
            foreach(var _alphabet in morseData)
            {
                if(_alphabet.Alphabet==alphabet)
                {
                    return _alphabet.Morse;
                }
            }
            return " ";
        }
        public string ToMorsecode(string words)
        {
            for (int i=0;i<words.Length;i++)
            {
                string morsecode = ToMorse(words[i]);
                _morsecode.Append(morsecode+" ");
            }
            return _morsecode.ToString();
        }
    }
}
