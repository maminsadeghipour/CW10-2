namespace CW10_1;

class Program
{
    static void Main(string[] args)
    {

    }

    private void PrintWelcome(string message)
    {

        if (message.Length < 5) Console.WriteLine("INVALID");
        else Console.WriteLine($"*{message}*");


    }
}

