namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.Hulls;

public class HullGradeA : Hull
{
    private const int AHullHealthPoints = 500;

    public HullGradeA()
        : base(AHullHealthPoints) { }
}