using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Exceptions;

public class ObjectStrengthValueException : Exception
{
    public ObjectStrengthValueException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public ObjectStrengthValueException(string message)
        : base(message)
    {
    }

    public ObjectStrengthValueException()
    {
    }
}