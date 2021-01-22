using System;
using MorseCode.Nuget;
using System.Collections.Generic;
using System.Windows;

namespace Just_testing
{
    class Program
    {
        public static  void Main(string[] args)
        {
            List<string> test = new List<string>() 
            { "-",".","...","-","..","-.","--." };
            Morse testing = new Morse();
            string _string = testing.ToWordLine(test);
            Console.WriteLine(_string);
            Alphabet _Test = new Alphabet();
            Console.WriteLine(_Test.ToMorsecode(_string));
            ToMorsewithSound morsewithsound = new ToMorsewithSound();
            morsewithsound.FromAlphabetForConsole(100, _string);
            Console.WriteLine(_string);
            testing.ToAlphabet(".");
        }
    }
}

