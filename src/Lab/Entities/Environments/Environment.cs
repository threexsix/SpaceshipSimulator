using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.MovementDevices;
using Itmo.ObjectOrientedProgramming.Lab1.Exceptions;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Environments;

public abstract class Environment
{
    private readonly List<Obstacle> _containedObstacles;

    protected Environment(
        IReadOnlyCollection<Obstacle> allowedObstacles,
        IReadOnlyCollection<MovementDevice> requiredEngines,
        IReadOnlyCollection<Obstacle> obstacles)
    {
        AllowedObstacles = allowedObstacles;
        RequiredEngines = requiredEngines;
        if (!ValidateObstacles(obstacles))
        {
            throw new ObstacleMatchingException();
        }

        _containedObstacles = new List<Obstacle>(obstacles);
    }

    public IReadOnlyCollection<Obstacle> ContainedObstacles => _containedObstacles;
    public IReadOnlyCollection<Obstacle> AllowedObstacles { get; }
    public IReadOnlyCollection<MovementDevice> RequiredEngines { get; }

    private bool ValidateObstacles(IReadOnlyCollection<Obstacle>? obstacles)
    {
        return obstacles != null && obstacles.All(obstacle =>
            AllowedObstacles.Any(eng => eng.ObstacleType == obstacle.ObstacleType));
    }
}