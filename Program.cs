// See https://aka.ms/new-console-template for more information

using MoreNETfun;

internal class Program
{
    private static void Main(string[] args)
    {
        PrintStuff ps = new PrintStuff("PT");
        string name = "";
        System.Console.WriteLine("Please enter your name:");
        name = System.Console.ReadLine();
        
        ps.PrintName(name);
    }
}

