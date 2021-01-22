using System;
using System.Collections.Generic;
using System.Text;
using MorseCode.Nuget.Extension;

namespace MorseCode.Nuget
{
    internal class Factory
    {
        internal static StringBuilder StringbuilderConstructor()
        {
            return new StringBuilder();
        }
        public static ISegregate SegregateConstructor()
        {
            return new Segregate();
        }
        public static Morsecode MorsecodeConstructor()
        {
            return new Morsecode();
        }
        public static IAlphabet AlphabetConstructor()
        {
            return new Alphabet();
        }
        public static IMorse MorseConstructor()
        {
            return new Morse();
        }
    }
}
