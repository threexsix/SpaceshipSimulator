using Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.Hulls;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.MovementDevices.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.MovementDevices.JumpDrives;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships;

public class Vaklas : Spaceship
{
    public Vaklas(bool isphotonic)
        : base(new ImpulseEngineE(), new GammaDrive(), new DeflectorGradeC(isphotonic), new HullGradeB(), false)
    {
    }
}