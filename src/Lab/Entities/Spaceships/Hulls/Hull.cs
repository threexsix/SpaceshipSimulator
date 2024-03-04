using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.Hulls;

public abstract class Hull
{
    protected Hull(ObjectStrength objectStrengths)
    {
        ObjectStrengths = objectStrengths;
    }

    public ObjectStrength ObjectStrengths { get; }
}