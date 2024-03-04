using Itmo.ObjectOrientedProgramming.Lab1.Entities.Route;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships;
using Itmo.ObjectOrientedProgramming.Lab1.Enums;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services;

public class FlightValidatorService
{
    private readonly Route _route;
    private readonly CollisionHandlerService _collisionHandlerService;
    private readonly RequirementHandlerService _requirementHandlerService;

    public FlightValidatorService(Spaceship spaceship, Route route)
    {
        _route = route;
        _collisionHandlerService = new CollisionHandlerService(spaceship);
        _requirementHandlerService = new RequirementHandlerService(spaceship);
    }

    public ExitCodes Validate()
    {
        foreach (Segment segment in _route.Segments)
        {
            if (!_requirementHandlerService.Handle(segment))
            {
                return ExitCodes.Lost;
            }

            if (_collisionHandlerService.Handle(segment) is ExitCodes.Destroyed or ExitCodes.CrewDead)
            {
                return _collisionHandlerService.Handle(segment);
            }
        }

        return ExitCodes.Succeeded;
    }
}