using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environments;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Route;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships;
using Itmo.ObjectOrientedProgramming.Lab1.Enums;
using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Services;
using Xunit;
using Xunit.Abstractions;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class FuelComporationTest
{
    private readonly ITestOutputHelper _testOutputHelper;

    public FuelComporationTest(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[]
            {
                new Vaklas(false), new Shuttle(), new Route(),
                new Segment(new HighDensityNebulae(new List<Obstacle> { }), 1555), true,
            },
        };

    [Theory]
    [MemberData(nameof(Data))]
    public void SpaceshipCompareOnRoadFuel(Spaceship s1, Spaceship s2, Route r1, Segment seg1, bool expected)
    {
        Fuel fuel1 = 0, fuel2 = 0;
        if (r1 != null)
        {
            r1.AddSegment(seg1);
            MovementCalculatorService sim = new(s1, r1);
            if (sim.Simulate() == ExitCodes.Succeeded)
            {
                fuel1 = sim.TotalMatter.Value;
            }

            sim = new MovementCalculatorService(s2, r1);
            if (sim.Simulate() == ExitCodes.Succeeded)
            {
                fuel2 = sim.TotalMatter.Value;
            }
        }

        Assert.Equal(expected, fuel1.Value > fuel2.Value);
    }
}