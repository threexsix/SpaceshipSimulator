namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.Deflectors;

public class DeflectorGradeA : Deflector
{
    private const int ADeflectorHealthPoints = 1000;

    public DeflectorGradeA(bool isPhoton)
        : base(isPhoton, ADeflectorHealthPoints) { }
}