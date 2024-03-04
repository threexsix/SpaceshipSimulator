using System;
using Itmo.ObjectOrientedProgramming.Lab1.Exceptions;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public class Time
{
    private const int MinValue = 0;
    public Time(int value)
    {
        if (value < MinValue)
            throw new TimeValueException("Time should be above zero");
        Value = value;
    }

    public int Value { get; }

    public static implicit operator Time(int value)
    {
        return new Time(value);
    }

    public static explicit operator int(Time? time)
    {
        if (time != null) return time.Value;
        throw new InvalidOperationException();
    }

    public static Time operator +(Time left, Time right)
    {
        if (left is null || right is null)
        {
            throw new InvalidOperationException();
        }

        return new Time(left.Value + right.Value);
    }

    public static Time operator *(Time left, Time right)
    {
        if (left is null || right is null)
        {
            throw new InvalidOperationException();
        }

        return new Time(left.Value * right.Value);
    }

    public static Time operator -(Time left, Time right)
    {
        if (left is null || right is null)
        {
            throw new InvalidOperationException();
        }

        return new Time(left.Value - right.Value);
    }

    public static bool operator >(Time? left, Time? right)
    {
        if ((left != null) && (right != null)) return left.Value > right.Value;
        return false;
    }

    public static bool operator <(Time? left, Time? right)
    {
        if ((left != null) && (right != null)) return left.Value < right.Value;
        return false;
    }

    public static int ToInt32(Time left, Time right)
    {
        throw new InvalidOperationException();
    }

    public static Time Multiply(Time left, Time right)
    {
        if (left is null || right is null)
        {
            throw new InvalidOperationException();
        }

        return new Time(left.Value * right.Value);
    }

    public static Time Add(Time left, Time right)
    {
        if (left is null || right is null)
        {
            throw new InvalidOperationException();
        }

        return new Time(left.Value + right.Value);
    }

    public static Time Subtract(Time left, Time right)
    {
        if (left is null || right is null)
        {
            throw new InvalidOperationException();
        }

        return new Time(left.Value - right.Value);
    }

    public static Time ToTime(int value)
    {
        return new Time(value);
    }

    public int CompareTo(object? obj)
    {
        if (obj is null) return 1;
        if (obj is Time otherTime)
            return Value.CompareTo(otherTime.Value);
        else
            throw new ArgumentException("Object is not a Time");
    }

    public bool Equals(Time? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return Value == other.Value;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj is Time otherTime)
            return Equals(otherTime);
        return false;
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }
}