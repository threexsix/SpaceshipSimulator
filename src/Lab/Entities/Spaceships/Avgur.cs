using Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.Hulls;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.MovementDevices.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.MovementDevices.JumpDrives;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships;

public class Avgur : Spaceship
{
    public Avgur(bool isphotonic)
        : base(new ImpulseEngineE(), new AlphaDrive(), new DeflectorGradeA(isphotonic), new HullGradeA(), false)
    {
    }
}