using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environments;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Route;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services;

public class RequirementHandlerService
{
    private readonly Spaceship _spaceship;

    public RequirementHandlerService(Spaceship spaceship)
    {
        _spaceship = spaceship;
    }

    public bool Handle(Segment? segment)
    {
        if (segment is null) return false;
        if (segment.Environment is RegularSpace or NitrinoNebulae)
        {
            return segment.Environment.RequiredEngines.Any(eng =>
                eng.MovementType == _spaceship.Engine.MovementType);
        }

        if (segment.Environment is HighDensityNebulae)
        {
            if (_spaceship.JumpDrive is null || segment.Distance > _spaceship.JumpDrive.Distance) return false;

            return segment.Environment.RequiredEngines.Any(eng =>
                 eng.MovementType == _spaceship.JumpDrive.MovementType);
        }

        return false;
    }
}