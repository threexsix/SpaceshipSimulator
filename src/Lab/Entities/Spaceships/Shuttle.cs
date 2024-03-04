using Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.Hulls;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.MovementDevices.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships;

public class Shuttle : Spaceship
{
    public Shuttle()
        : base(new ImpulseEngineC(), null, null, new HullGradeC(), false)
    {
    }
}