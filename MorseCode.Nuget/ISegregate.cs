using System;
using System.Collections.Generic;
using System.Text;

namespace MorseCode.Nuget.Extension
{
    public interface ISegregate
    {
        bool MorseDataisValidated(string morse);
    }
}
