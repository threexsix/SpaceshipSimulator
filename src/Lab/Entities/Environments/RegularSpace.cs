﻿using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.MovementDevices;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.MovementDevices.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Environments;

public class RegularSpace : Environment
{
    // these collections are static to maintain invariant for all instances of the class
    private static readonly IReadOnlyCollection<Obstacle> Obstacles = new List<Obstacle>
        { new Asteroid(), new Meteorite() };

    private static readonly IReadOnlyCollection<MovementDevice> Engines = new List<MovementDevice>
        { new ImpulseEngineC(), new ImpulseEngineE() };

    public RegularSpace(IReadOnlyCollection<Obstacle> containedObstacles)
        : base(Obstacles, Engines, containedObstacles)
    {
    }
}