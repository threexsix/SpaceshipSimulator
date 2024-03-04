namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.Deflectors;

public class DeflectorGradeC : Deflector
{
    private const int CDeflectorHealthPoints = 50;

    public DeflectorGradeC(bool isPhoton)
        : base(isPhoton, CDeflectorHealthPoints) { }
}