using Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.Hulls;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.MovementDevices.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships;

public class Meridian : Spaceship
{
    public Meridian(bool isphotonic)
        : base(new ImpulseEngineE(), null, new DeflectorGradeB(isphotonic), new HullGradeB(), true)
    {
    }
}