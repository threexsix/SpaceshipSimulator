using Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.Hulls;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.MovementDevices.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.MovementDevices.JumpDrives;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships;

public class Stella : Spaceship
{
    public Stella(bool isphotonic)
        : base(new ImpulseEngineC(), new OmegaDrive(), new DeflectorGradeC(isphotonic), new HullGradeC(), false)
    {
    }
}