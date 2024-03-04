using System;
using System.Runtime.Serialization;

namespace Itmo.ObjectOrientedProgramming.Lab1.Exceptions;

public class ObstacleMatchingException : Exception
{
    public ObstacleMatchingException()
    {
    }

    public ObstacleMatchingException(string? message)
        : base(message)
    {
    }

    public ObstacleMatchingException(string? message, Exception? innerException)
        : base(message, innerException)
    {
    }

    protected ObstacleMatchingException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}