using Itmo.ObjectOrientedProgramming.Lab1.Enums;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;

public class Meteorite : Obstacle
{
    private const int MeteoriteDamage = 125;
    private const ObstacleType Type = ObstacleType.Meteorite;

    public Meteorite()
        : base(MeteoriteDamage, Type)
    {
    }
}