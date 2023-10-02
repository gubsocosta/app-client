using System.Globalization;
using System.Threading;
using AppClient.Repositories;

namespace AppClient
{
    class Program
    {
        static void Main(string[] args)
        {
            DefineCulture();
            ExecuteAppWithDataInFile();
        }

        private static void DefineCulture()
        {
            var culture = new CultureInfo("pt-BR");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
        }

        private static void ExecuteAppWithDataInMemory()
        {
            var clientRepository = new MemoryClientRepository();
            DefineCulture();
            Menu.Execute(clientRepository);
        }

        private static void ExecuteAppWithDataInFile()
        {
            var clientRepository = new FileClientRepository();
            DefineCulture();
            Menu.Execute(clientRepository);
            clientRepository.StoreData();
        }
    }
}