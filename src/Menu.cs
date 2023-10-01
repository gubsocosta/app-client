using System;
using AppClient.Entities;
using AppClient.Repositories;
using AppClient.Repositories.Exceptions;

namespace AppClient;

public static class Menu
{
    public static void Execute(IClientRepository clientRepository)
    {
        int option;
        do
        {
            ShowMenu();
            Console.WriteLine("Choose one of the options above:");
            option = int.Parse(Console.ReadLine());
            ChooseOption(option, clientRepository);
        } while (option != 5);
    }

    private static void ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Client Registration");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("1 - Create a client");
        Console.WriteLine("2 - Show all clients");
        Console.WriteLine("3 - Edit a client");
        Console.WriteLine("4 - Delete a client");
        Console.WriteLine("5 - Exit");
    }

    private static void ChooseOption(int option, IClientRepository clientRepository)
    {
        switch (option)
        {
            case 1:
                {
                    ClearScreen();
                    CreateClient(clientRepository);
                    return;
                }
            case 2:
                {
                    ClearScreen();
                    ShowAllClients(clientRepository);
                    return;
                }
            case 3:
                {
                    ClearScreen();
                    EditClient(clientRepository);
                    return;
                }
            case 4:
                {
                    ClearScreen();
                    DeleteClient(clientRepository);
                    return;
                }
            case 5:
                {
                    Console.WriteLine("Finishing the program. Press <ENTER> to close...");
                    Console.ReadKey();
                    return;
                }
            default:
                {
                    ClearScreen();
                    Console.WriteLine("Invalid Option. Press <ENTER> to continue...");
                    Console.ReadKey();
                    break;
                }
        }
    }

    private static void ClearScreen()
    {
        Console.Clear();
    }

    private static void ShowClient(Client client)
    {
        Console.WriteLine("ID............: " + client.Id);
        Console.WriteLine("Name..........: " + client.Name);
        Console.WriteLine("Discount value: " + client.DiscountValue.ToString("0.00"));
        Console.WriteLine("Birth date....: " + client.BirthDate);
        Console.WriteLine("Created at....: " + client.CreatedAt);
        Console.WriteLine("---------------------------------------------------");
    }

    private static void ShowAllClients(IClientRepository clientRepository)
    {
        var clients = clientRepository.GetAll();
        foreach (var client in clients)
        {
            ShowClient(client);
        }
        Console.WriteLine("Press <ENTER> to continue...");
        Console.ReadKey();
    }

    private static void CreateClient(IClientRepository clientRepository)
    {
        Console.Write("Name: ");
        var name = Console.ReadLine();
        Console.Write(Environment.NewLine);

        Console.Write("Discount value: ");
        var discountValue = decimal.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);

        Console.Write("Birth date: ");
        var birthDate = DateOnly.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);

        var newClient = clientRepository.Create(name, birthDate, discountValue);
        ShowClient(newClient);
        Console.WriteLine("Client created successful! Press <ENTER> to continue...");
        Console.ReadKey();
    }

    private static void EditClient(IClientRepository clientRepository)
    {
        Console.Write("Enter the client's ID: ");
        var clientId = int.Parse(Console.ReadLine());
        try
        {
            var foundClient = clientRepository.GetById(clientId);
            if (foundClient == null)
            {
                Console.WriteLine("Client not found. Press <ENTER> to continue...");
                return;
            }
            ShowClient(foundClient);

            Console.Write("Name: ");
            var name = Console.ReadLine();
            Console.Write(Environment.NewLine);

            Console.Write("Discount value: ");
            var discountValue = decimal.Parse(Console.ReadLine());
            Console.Write(Environment.NewLine);

            Console.Write("Birth date: ");
            var birthDate = DateOnly.Parse(Console.ReadLine());
            Console.Write(Environment.NewLine);

            var updatedClient = clientRepository.Update(clientId, name, birthDate, discountValue);

            Console.WriteLine("Client updated successful! Press <ENTER> to continue...");
            ShowClient(updatedClient);
        }
        catch (ClientNotFoundException exception)
        {
            Console.WriteLine("Client not found. Press <ENTER> to continue...");
        }
        catch (Exception exception)
        {
            Console.WriteLine("Error to edit the client. Press <ENTER> to continue...");
        }
        finally
        {
            Console.ReadKey();
        }
    }

    private static void DeleteClient(IClientRepository clientRepository)
    {
        Console.Write("Enter the client's ID: ");
        var clientId = int.Parse(Console.ReadLine());
        try
        {
            clientRepository.Delete(clientId);
            Console.WriteLine("Client deleted successful! Press <ENTER> to continue...");
        }
        catch (ClientNotFoundException exception)
        {
            Console.WriteLine("Client not found. Press <ENTER> to continue...");
        }
        catch (Exception exception)
        {
            Console.WriteLine("Error to delete the client. Press <ENTER> to continue...");
        }
        finally
        {
            Console.ReadKey();
        }
    }
}