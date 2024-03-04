using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.Deflectors;

public abstract class Deflector
{
    private const int PhotonChargesLimit = 3;
    private int _photonCharges;

    protected Deflector(bool isPhoton, ObjectStrength objectStrengths)
    {
        IsPhoton = isPhoton;
        ObjectStrengths = objectStrengths;
        _photonCharges = isPhoton == false ? PhotonChargesLimit : 0;
    }

    public bool IsPhoton { get; }
    public ObjectStrength ObjectStrengths { get; }

    public bool CounterFlash()
    {
        _photonCharges++;
        return _photonCharges <= PhotonChargesLimit;
    }
}