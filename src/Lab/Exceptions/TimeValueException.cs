using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Exceptions;

public class TimeValueException : Exception
{
    public TimeValueException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public TimeValueException(string message)
        : base(message)
    {
    }

    public TimeValueException()
    {
    }
}