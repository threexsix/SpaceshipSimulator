using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.MovementDevices;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.MovementDevices.JumpDrives;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Environments;

public class HighDensityNebulae : Environment
{
    // these collections are static to maintain invariant for all instances of the class
    private static readonly IReadOnlyCollection<Obstacle> Obstacles = new List<Obstacle>
        { new Flash() };

    private static readonly IReadOnlyCollection<MovementDevice> Engines = new List<MovementDevice>
        { new AlphaDrive(), new GammaDrive(), new OmegaDrive() };

    public HighDensityNebulae(IReadOnlyCollection<Obstacle> containedObstacles)
        : base(Obstacles, Engines, containedObstacles)
    {
    }
}