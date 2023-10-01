
using System;
using System.Collections.Generic;
using AppClient.Entities;

namespace AppClient.Repositories;

public interface IClientRepository
{
    public Client? GetById(int clientId);
    public List<Client> GetAll();
    public Client Create(string name, DateOnly birthDate, decimal discountValue);
    public Client Update(int clientId, string name, DateOnly birthDate, decimal discountValue);
    public void Delete(int clientId);
}