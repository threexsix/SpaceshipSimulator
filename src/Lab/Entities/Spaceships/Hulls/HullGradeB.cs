namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.Hulls;

public class HullGradeB : Hull
{
    private const int BHullHealthPoints = 125;

    public HullGradeB()
        : base(BHullHealthPoints) { }
}