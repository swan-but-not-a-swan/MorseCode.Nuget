using System.Collections.Generic;

namespace MorseCode.Nuget
{
    public interface IMorse
    {
        char ToAlphabet(string morse);
        string ToWordLine(List<string> morse);
    }
}