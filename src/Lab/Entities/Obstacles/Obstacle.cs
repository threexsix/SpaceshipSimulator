using Itmo.ObjectOrientedProgramming.Lab1.Enums;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;

public abstract class Obstacle
{
    protected Obstacle(ObjectStrength damage, ObstacleType obstacleType)
    {
        Damage = damage;
        ObstacleType = obstacleType;
    }

    public ObjectStrength Damage { get; }
    public ObstacleType ObstacleType { get; }
}