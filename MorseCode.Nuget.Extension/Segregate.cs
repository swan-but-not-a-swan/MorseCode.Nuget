using System;
using System.Collections.Generic;
using System.Text;

namespace MorseCode.Nuget.Extension
{
    public class Segregate:ISegregate
    {
        public bool MorseDataisValidated(string morse)
        {
            for(int i=0;i<morse.Length;i++)
            {
                char a = morse[i];
                bool dataValidation = DataValidation(a);
                if(!dataValidation)
                {
                    return false;
                }
            }
            return true;
        }
        private bool DataValidation(char a)
        {
            if((a=='.')||(a=='-')||(a==' '))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
