using System;
using System.Collections.Generic;
using System.Text;

namespace MorseCode.Nuget
{
    public class Morsecode
    {
        public string Morse { get; private set; }
        public char Alphabet { get; private set; }
        public List<Morsecode> GetMorseData()
        {
            List<Morsecode> morsecode = new List<Morsecode>();
            morsecode.Add(new Morsecode { Morse = ".-", Alphabet = 'A' });
            morsecode.Add(new Morsecode { Morse="-...", Alphabet=  'B' });
            morsecode.Add(new Morsecode { Morse = "-.-.", Alphabet = 'C' });
            morsecode.Add(new Morsecode { Morse = "-..", Alphabet = 'D' });
            morsecode.Add(new Morsecode { Morse = ".", Alphabet = 'E' });
            morsecode.Add(new Morsecode { Morse = "..-.", Alphabet = 'F' });
            morsecode.Add(new Morsecode { Morse = "--.", Alphabet = 'G' });
            morsecode.Add(new Morsecode { Morse = "....", Alphabet = 'H' });
            morsecode.Add(new Morsecode { Morse = "..", Alphabet = 'I' });
            morsecode.Add(new Morsecode { Morse = ".---", Alphabet = 'J' });
            morsecode.Add(new Morsecode { Morse = "-.-", Alphabet = 'K' });
            morsecode.Add(new Morsecode { Morse = ".-..", Alphabet = 'L' });
            morsecode.Add(new Morsecode { Morse = "--", Alphabet = 'M' });
            morsecode.Add(new Morsecode { Morse = "-.", Alphabet = 'N' });
            morsecode.Add(new Morsecode { Morse = "---", Alphabet = 'O' });
            morsecode.Add(new Morsecode { Morse = ".--.", Alphabet = 'P' });
            morsecode.Add(new Morsecode { Morse = "--.-", Alphabet = 'Q' });
            morsecode.Add(new Morsecode { Morse = ".-.", Alphabet = 'R' });
            morsecode.Add(new Morsecode { Morse = "...", Alphabet = 'S' });
            morsecode.Add(new Morsecode { Morse = "-", Alphabet = 'T' });
            morsecode.Add(new Morsecode { Morse = "..-", Alphabet = 'U' });
            morsecode.Add(new Morsecode { Morse = "...-", Alphabet = 'V' });
            morsecode.Add(new Morsecode { Morse = ".--", Alphabet = 'W' });
            morsecode.Add(new Morsecode { Morse = "-..-", Alphabet = 'X' });
            morsecode.Add(new Morsecode { Morse = "-.--", Alphabet = 'Y' });
            morsecode.Add(new Morsecode { Morse = "--..", Alphabet = 'Z' });
            morsecode.Add(new Morsecode { Morse = ".----", Alphabet = '1' });
            morsecode.Add(new Morsecode { Morse = "..---", Alphabet = '2' });
            morsecode.Add(new Morsecode { Morse = "...--", Alphabet = '3' });
            morsecode.Add(new Morsecode { Morse = "....-", Alphabet = '4' });
            morsecode.Add(new Morsecode { Morse = ".....", Alphabet = '5' });
            morsecode.Add(new Morsecode { Morse = "-....", Alphabet = '6' });
            morsecode.Add(new Morsecode { Morse = "--...", Alphabet = '7' });
            morsecode.Add(new Morsecode { Morse = "---..", Alphabet = '8' });
            morsecode.Add(new Morsecode { Morse = "----.", Alphabet = '9' });
            morsecode.Add(new Morsecode { Morse = "-----", Alphabet = '0' });
            morsecode.Add(new Morsecode { Morse = "--..--", Alphabet = ',' });
            morsecode.Add(new Morsecode { Morse = "..--..", Alphabet = '?' });
            morsecode.Add(new Morsecode { Morse = "---...", Alphabet = ':' });
            morsecode.Add(new Morsecode { Morse = "-....-", Alphabet = '-' });
            morsecode.Add(new Morsecode { Morse = ".-..-.", Alphabet = '"' });
            morsecode.Add(new Morsecode { Morse = "-.--.", Alphabet = '(' });
            morsecode.Add(new Morsecode { Morse = "-...-", Alphabet = '=' });
            morsecode.Add(new Morsecode { Morse = "-..-", Alphabet = '*' });
            morsecode.Add(new Morsecode { Morse = ".-.-.-", Alphabet = '.' });
            morsecode.Add(new Morsecode { Morse = "-.-.-.", Alphabet = ';' });
            morsecode.Add(new Morsecode { Morse = "-..-.", Alphabet = '/'});
            morsecode.Add(new Morsecode { Morse = ".----.", Alphabet = '\'' });
            morsecode.Add(new Morsecode { Morse = "_.__._", Alphabet = ')' });
            morsecode.Add(new Morsecode { Morse = ".-.-.", Alphabet = '+' });
            morsecode.Add(new Morsecode { Morse = ".__._.", Alphabet = '@' });
            morsecode.Add(new Morsecode { Morse = " ", Alphabet = ' ' });
            return morsecode;
        }
    }
}