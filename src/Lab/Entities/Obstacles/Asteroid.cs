using Itmo.ObjectOrientedProgramming.Lab1.Enums;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;

public class Asteroid : Obstacle
{
    private const int AsteroidDamage = 25;

    private const ObstacleType Type = ObstacleType.Asteroid;

    public Asteroid()
        : base(AsteroidDamage, Type) { }
}