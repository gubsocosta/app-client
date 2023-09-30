using System;

namespace AppClient;

public static class Menu
{
    public static void Show()
    {
        Console.Clear();
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Client Registration");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("1 - Create a client");
        Console.WriteLine("2 - Show a client");
        Console.WriteLine("3 - Edit a client");
        Console.WriteLine("4 - Delete a client");
        Console.WriteLine("5 - Exit");
        Console.WriteLine("Choose one of the options above:");
    }
}