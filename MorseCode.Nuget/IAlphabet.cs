namespace MorseCode.Nuget
{
    public interface IAlphabet
    {
        string ToMorse(char alphabet);
        string ToMorsecode(string words);
    }
}