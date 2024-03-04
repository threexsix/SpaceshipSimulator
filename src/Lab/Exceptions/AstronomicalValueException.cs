using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Exceptions;

public class AstronomicalValueException : Exception
{
    public AstronomicalValueException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public AstronomicalValueException(string message)
        : base(message)
    {
    }

    public AstronomicalValueException()
    {
    }
}