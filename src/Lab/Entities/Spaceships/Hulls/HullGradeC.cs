namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.Hulls;

public class HullGradeC : Hull
{
    private const int CHullHealthPoints = 25;

    public HullGradeC()
        : base(CHullHealthPoints) { }
}