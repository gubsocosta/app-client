using System;

namespace AppClient
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Menu.Show();
                Console.ReadKey();
            }
        }
    }
}