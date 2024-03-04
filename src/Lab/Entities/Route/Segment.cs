using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environments;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Route;

public class Segment
{
    public Segment(Environment environment, AstronomicalUnit distance)
    {
        Environment = environment;
        Distance = distance;
    }

    public AstronomicalUnit Distance { get; }
    public Environment Environment { get; }
}