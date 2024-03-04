using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environments;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Route;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships;
using Itmo.ObjectOrientedProgramming.Lab1.Enums;
using Itmo.ObjectOrientedProgramming.Lab1.Services;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class SpaceshipNitrinoTest
{
    public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[]
            {
                new Shuttle(), new Route(),
                new Segment(new NitrinoNebulae(new List<Obstacle> { }), 1000), ExitCodes.Lost,
            },
            new object[]
            {
                new Vaklas(false), new Route(),
                new Segment(new NitrinoNebulae(new List<Obstacle> { }), 1000), ExitCodes.Succeeded,
            },
        };

    [Theory]
    [MemberData(nameof(Data))]
    public void SpaceshipOnRouteNitrino(Spaceship s1, Route r1, Segment seg1, ExitCodes expected)
    {
        if (r1 != null)
        {
            r1.AddSegment(seg1);
            MovementCalculatorService sim = new(s1, r1);
            Assert.Equal(expected, sim.Simulate());
        }
    }
}