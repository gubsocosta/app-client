using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AppClient.Entities;
using AppClient.Repositories.Exceptions;

namespace AppClient.Repositories;

public class FileClientRepository : IClientRepository
{
    private readonly string FilePath = "./clients.txt";
    private readonly List<Client> Clients = new List<Client>();


    public FileClientRepository()
    {
        GetFileData();
    }

    public void Delete(int clientId)
    {
        var foundClient = GetById(clientId);
        if (foundClient == null) throw new ClientNotFoundException();
        Clients.Remove(foundClient);
    }

    public List<Client> GetAll()
    {
        return Clients;
    }

    public Client? GetById(int clientId)
    {
        return Clients.FirstOrDefault(c => c.Id == clientId);
    }

    public Client Create(string name, DateOnly birthDate, decimal discountValue)
    {
        var id = Clients.Count + 1;
        var newClient = new Client(id, name, birthDate, discountValue);
        Clients.Add(newClient);
        return newClient;
    }

    public Client Update(int clientId, string name, DateOnly birthDate, decimal discountValue)
    {
        var foundClient = GetById(clientId);
        if (foundClient == null) throw new ClientNotFoundException();
        foundClient.Name = name;
        foundClient.DiscountValue = discountValue;
        foundClient.BirthDate = birthDate;
        return foundClient;
    }

    private void GetFileData()
    {
        if (File.Exists(FilePath))
        {
            var rawFileContent = File.ReadAllText(FilePath);
            var deserializedContent = System.Text.Json.JsonSerializer.Deserialize<List<Client>>(rawFileContent);
            Clients.AddRange(deserializedContent);
        }
    }

    public void StoreData()
    {
        var serializedContent = System.Text.Json.JsonSerializer.Serialize(Clients);
        File.WriteAllText(FilePath, serializedContent);
    }
}