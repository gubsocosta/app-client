using System;
using System.Runtime.Serialization;

namespace AppClient.Repositories.Exceptions;

[Serializable]
public class ClientNotFoundException : Exception
{
    public ClientNotFoundException()
    {
    }

    public ClientNotFoundException(string? message) : base(message)
    {
    }

    public ClientNotFoundException(string? message, RankException? innerException) : base(message, innerException)
    {
    }

    protected ClientNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}