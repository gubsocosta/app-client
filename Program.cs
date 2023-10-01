using System;
using System.Globalization;
using System.Threading;
using AppClient.Repositories;

namespace AppClient
{
    class Program
    {
        static readonly IClientRepository _clientRepository = new MemoryClientRepository();

        static void Main(string[] args)
        {
            DefineCulture();
            while (true)
            {
                Menu.ShowMenu();
                Menu.ChooseOption(_clientRepository);
                Console.ReadKey();
            }
        }

        private static void DefineCulture()
        {
            var culture = new CultureInfo("pt-BR");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
        }
    }
}