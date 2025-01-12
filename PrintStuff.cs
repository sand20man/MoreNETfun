// ReSharper disable All
namespace MoreNETfun;

internal class PrintStuff
{
    private readonly string language;
    //Constructor
    public PrintStuff()
    {
        language = "EN";
    }
    public PrintStuff(string temp)
    {
        language = temp;
    }
    public void PrintName(string n)
    {
        if (language == "EN")
        {
            System.Console.WriteLine("Hello, " + n + "!");
        }

        if (language == "PT")
        {
            System.Console.WriteLine("Oi, " + n + "!");
        }
    }
}