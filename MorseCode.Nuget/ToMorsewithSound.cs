using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MorseCode.Nuget
{
    public class ToMorsewithSound
    {
        private IAlphabet Alphabet = Factory.AlphabetConstructor(); 
         public void FromAlphabetForConsole(int unitDuration, string alphabet)
         {
            string morse = Alphabet.ToMorsecode(alphabet);
            for (int i = 0; i < morse.Length; i++)
            {
                ForConsole(morse[i], unitDuration);
            }
         }
        private void ForConsole(char symbol, int unitDuration)
        {
            int frequency = 900;
            string sleep = "sleep";
            if (symbol == '.')
            {
                Console.Beep(frequency, unitDuration);
                Console.WriteLine(sleep);
                Thread.Sleep(unitDuration);
            }
            if (symbol == '-')
            {
                Console.Beep(frequency, unitDuration * 3);
                Console.WriteLine(sleep);
                Thread.Sleep(unitDuration);
            }
            if (symbol == ' ')
            {

                Thread.Sleep(unitDuration * 3);
            }
            if (symbol == '/')
            {
                Thread.Sleep(unitDuration * 4);
            }
        }
        
    }
}
