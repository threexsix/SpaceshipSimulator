using Itmo.ObjectOrientedProgramming.Lab1.Enums;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;

public class Whale : Obstacle
{
    private const int WhaleDamage = 1000;
    private const ObstacleType Type = ObstacleType.Whale;

    public Whale()
        : base(WhaleDamage, Type) { }
}