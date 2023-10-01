using System;

namespace AppClient.Entities;

public class Client
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateOnly BirthDate { get; set; }
    public DateTime CreatedAt { get; set; }
    public decimal DiscountValue { get; set; }

    public Client(int id, string name, DateOnly birthDate, decimal discountValue)
    {
        Id = id;
        Name = name;
        BirthDate = birthDate;
        DiscountValue = discountValue;
        CreatedAt = DateTime.Now;
    }
}