using System;
using Itmo.ObjectOrientedProgramming.Lab1.Exceptions;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;
public class AstronomicalUnit
{
    private const int MinValue = 0;
    public AstronomicalUnit(int value)
    {
        if (value < MinValue)
            throw new AstronomicalValueException("AstronomicalUnit should be above zero");
        Value = value;
    }

    public int Value { get; }

    public static implicit operator AstronomicalUnit(int value)
    {
        return new AstronomicalUnit(value);
    }

    public static explicit operator int(AstronomicalUnit? astronomicalUnit)
    {
        if (astronomicalUnit != null) return astronomicalUnit.Value;
        throw new InvalidOperationException();
    }

    public static AstronomicalUnit operator +(AstronomicalUnit left, AstronomicalUnit right)
    {
        if (left is null || right is null)
        {
            throw new InvalidOperationException();
        }

        return new AstronomicalUnit(left.Value + right.Value);
    }

    public static AstronomicalUnit operator *(AstronomicalUnit left, AstronomicalUnit right)
    {
        if (left is null || right is null)
        {
            throw new InvalidOperationException();
        }

        return new AstronomicalUnit(left.Value * right.Value);
    }

    public static AstronomicalUnit operator /(AstronomicalUnit left, AstronomicalUnit right)
    {
        if (left is null || right is null)
        {
            throw new InvalidOperationException();
        }

        return new AstronomicalUnit(left.Value / right.Value);
    }

    public static AstronomicalUnit operator -(AstronomicalUnit left, AstronomicalUnit right)
    {
        if (left is null || right is null)
        {
            throw new InvalidOperationException();
        }

        return new AstronomicalUnit(left.Value - right.Value);
    }

    public static bool operator >(AstronomicalUnit? left, AstronomicalUnit? right)
    {
        if ((left != null) && (right != null)) return left.Value > right.Value;
        return false;
    }

    public static bool operator <(AstronomicalUnit? left, AstronomicalUnit? right)
    {
        if ((left != null) && (right != null)) return left.Value < right.Value;
        return false;
    }

    public static int ToInt32(AstronomicalUnit left, AstronomicalUnit right)
    {
        throw new InvalidOperationException();
    }

    public static AstronomicalUnit Multiply(AstronomicalUnit left, AstronomicalUnit right)
    {
        if (left is null || right is null)
        {
            throw new InvalidOperationException();
        }

        return new AstronomicalUnit(left.Value * right.Value);
    }

    public static AstronomicalUnit Divide(AstronomicalUnit left, AstronomicalUnit right)
    {
        if (left is null || right is null)
        {
            throw new InvalidOperationException();
        }

        return new AstronomicalUnit(left.Value / right.Value);
    }

    public static AstronomicalUnit Add(AstronomicalUnit left, AstronomicalUnit right)
    {
        if (left is null || right is null)
        {
            throw new InvalidOperationException();
        }

        return new AstronomicalUnit(left.Value + right.Value);
    }

    public static AstronomicalUnit Subtract(AstronomicalUnit left, AstronomicalUnit right)
    {
        if (left is null || right is null)
        {
            throw new InvalidOperationException();
        }

        return new AstronomicalUnit(left.Value - right.Value);
    }

    public static AstronomicalUnit ToAstronomicalUnit(int value)
    {
        return new AstronomicalUnit(value);
    }

    public int CompareTo(object? obj)
    {
        if (obj is null) return 1;
        if (obj is AstronomicalUnit otherAstronomicalUnit)
            return Value.CompareTo(otherAstronomicalUnit.Value);
        else
            throw new ArgumentException("Object is not a AstronomicalUnit");
    }

    public bool Equals(AstronomicalUnit? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return Value == other.Value;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj is AstronomicalUnit otherAstronomicalUnit)
            return Equals(otherAstronomicalUnit);
        return false;
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }
}