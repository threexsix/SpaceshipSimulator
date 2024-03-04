using System;
using Itmo.ObjectOrientedProgramming.Lab1.Exceptions;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public class ObjectStrength
{
    private const int MinValue = 0;
    private ObjectStrength(int value)
    {
        if (value < MinValue)
            throw new ObjectStrengthValueException("ObjectStrength should be above zero");
        Value = value;
    }

    public int Value { get; }

    public static implicit operator ObjectStrength(int value)
    {
        return new ObjectStrength(value);
    }

    public static explicit operator int(ObjectStrength? objectStrength)
    {
        if (objectStrength != null) return objectStrength.Value;
        throw new InvalidOperationException();
    }

    public static ObjectStrength operator +(ObjectStrength left, ObjectStrength right)
    {
        if (left is null || right is null)
        {
            throw new InvalidOperationException();
        }

        return new ObjectStrength(left.Value + right.Value);
    }

    public static ObjectStrength operator -(ObjectStrength left, ObjectStrength right)
    {
        if (left is null || right is null)
        {
            throw new InvalidOperationException();
        }

        return new ObjectStrength(left.Value - right.Value);
    }

    public static bool operator >(ObjectStrength? left, ObjectStrength? right)
    {
        if ((left != null) && (right != null)) return left.Value > right.Value;
        return false;
    }

    public static bool operator <(ObjectStrength? left, ObjectStrength? right)
    {
        if ((left != null) && (right != null)) return left.Value < right.Value;
        return false;
    }

    public static int ToInt32(ObjectStrength left, ObjectStrength right)
    {
        throw new InvalidOperationException();
    }

    public static ObjectStrength Add(ObjectStrength left, ObjectStrength right)
    {
        if (left is null || right is null)
        {
            throw new InvalidOperationException();
        }

        return new ObjectStrength(left.Value + right.Value);
    }

    public static ObjectStrength Subtract(ObjectStrength left, ObjectStrength right)
    {
        if (left is null || right is null)
        {
            throw new InvalidOperationException();
        }

        return new ObjectStrength(left.Value - right.Value);
    }

    public static ObjectStrength ToObjectStrength(int value)
    {
        return new ObjectStrength(value);
    }

    public int CompareTo(object? obj)
    {
        if (obj is null) return 1;
        if (obj is ObjectStrength otherStrength)
            return Value.CompareTo(otherStrength.Value);
        else
            throw new ArgumentException("Object is not a ObjectStrength");
    }

    public bool Equals(ObjectStrength? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return Value == other.Value;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj is ObjectStrength otherStrength)
            return Equals(otherStrength);
        return false;
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }
}