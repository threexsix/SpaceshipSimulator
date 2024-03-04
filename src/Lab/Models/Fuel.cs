using System;
using Itmo.ObjectOrientedProgramming.Lab1.Exceptions;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;
public class Fuel
{
    private const int MinValue = 0;
    public Fuel(int value)
    {
        if (value < MinValue)
            throw new FuelValueException("Fuel should be above zero");
        Value = value;
    }

    public int Value { get; }

    public static implicit operator Fuel(int value)
    {
        return new Fuel(value);
    }

    public static explicit operator int(Fuel? fuel)
    {
        if (fuel != null) return fuel.Value;
        throw new InvalidOperationException();
    }

    public static Fuel operator +(Fuel left, Fuel right)
    {
        if (left is null || right is null)
        {
            throw new InvalidOperationException();
        }

        return new Fuel(left.Value + right.Value);
    }

    public static Fuel operator *(Fuel left, Fuel right)
    {
        if (left is null || right is null)
        {
            throw new InvalidOperationException();
        }

        return new Fuel(left.Value * right.Value);
    }

    public static Fuel operator -(Fuel left, Fuel right)
    {
        if (left is null || right is null)
        {
            throw new InvalidOperationException();
        }

        return new Fuel(left.Value - right.Value);
    }

    public static bool operator >(Fuel? left, Fuel? right)
    {
        if ((left != null) && (right != null)) return left.Value > right.Value;
        return false;
    }

    public static bool operator <(Fuel? left, Fuel? right)
    {
        if ((left != null) && (right != null)) return left.Value < right.Value;
        return false;
    }

    public static int ToInt32(Fuel left, Fuel right)
    {
        throw new InvalidOperationException();
    }

    public static Fuel Multiply(Fuel left, Fuel right)
    {
        if (left is null || right is null)
        {
            throw new InvalidOperationException();
        }

        return new Fuel(left.Value * right.Value);
    }

    public static Fuel Add(Fuel left, Fuel right)
    {
        if (left is null || right is null)
        {
            throw new InvalidOperationException();
        }

        return new Fuel(left.Value + right.Value);
    }

    public static Fuel Subtract(Fuel left, Fuel right)
    {
        if (left is null || right is null)
        {
            throw new InvalidOperationException();
        }

        return new Fuel(left.Value - right.Value);
    }

    public static Fuel ToFuel(int value)
    {
        return new Fuel(value);
    }

    public int CompareTo(object? obj)
    {
        if (obj is null) return 1;
        if (obj is Fuel otherFuel)
            return Value.CompareTo(otherFuel.Value);
        else
            throw new ArgumentException("Object is not a Fuel");
    }

    public bool Equals(Fuel? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return Value == other.Value;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj is Fuel otherFuel)
            return Equals(otherFuel);
        return false;
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }
}