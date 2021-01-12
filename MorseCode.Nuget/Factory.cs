using System;
using System.Collections.Generic;
using System.Text;

namespace MorseCode.Nuget
{
    internal static class Factory
    {
        public static ISegregate SegregateConstructor()
        {
            return new Segregate();
        }
        public static Morsecode MorsecodeConstructor()
        {
            return new Morsecode();
        }
        internal static StringBuilder StringbuilderConstructor()
        {
            return new StringBuilder();
        }
    }
}
