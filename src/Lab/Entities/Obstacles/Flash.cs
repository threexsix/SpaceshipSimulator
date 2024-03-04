using Itmo.ObjectOrientedProgramming.Lab1.Enums;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;

public class Flash : Obstacle
{
    private const int FlashDamage = 0;
    private const ObstacleType Type = ObstacleType.Flash;

    public Flash()
        : base(FlashDamage, Type)
    {
    }
}