namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.Deflectors;

public class DeflectorGradeB : Deflector
{
    private const int BDeflectorHealthPoints = 250;

    public DeflectorGradeB(bool isPhoton)
        : base(isPhoton, BDeflectorHealthPoints) { }
}