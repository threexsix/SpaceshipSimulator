using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Exceptions;

public class FuelValueException : Exception
{
    public FuelValueException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public FuelValueException(string message)
        : base(message)
    {
    }

    public FuelValueException()
    {
    }
}