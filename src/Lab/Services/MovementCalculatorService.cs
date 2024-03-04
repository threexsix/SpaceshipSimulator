using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environments;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Route;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships;
using Itmo.ObjectOrientedProgramming.Lab1.Enums;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services;

public class MovementCalculatorService
{
    private readonly Spaceship _spaceship;
    private readonly Route _route;
    private readonly ExitCodes _validationCode;

    public MovementCalculatorService(Spaceship spaceship, Route route)
    {
        _spaceship = spaceship;
        _route = route;
        _validationCode = new FlightValidatorService(_spaceship, _route).Validate();
        TotalFuel = 0;
        TotalMatter = 0;
        TotalTime = 0;
    }

    public Time TotalTime { get; private set; }
    public Fuel TotalFuel { get; private set; }
    public Fuel TotalMatter { get; private set; }

    public ExitCodes Simulate()
    {
        if (_validationCode is ExitCodes.Destroyed or ExitCodes.Lost or ExitCodes.CrewDead)
            return _validationCode;

        foreach (Segment segment in _route.Segments)
        {
            MovementHandler(segment);
        }

        return _validationCode;
    }

    private void MovementHandler(Segment segment)
    {
        if (segment.Environment is HighDensityNebulae)
        {
            if (_spaceship.JumpDrive == null)
                throw new ArgumentException("JumpDrive cannot be null in MovementHandler");
            TotalTime += segment.Distance.Value / _spaceship.JumpDrive.Speed.Value;
            TotalMatter += _spaceship.JumpDrive.MatterConsumption();

            return;
        }

        TotalTime += segment.Distance.Value / _spaceship.Engine.AverageSpeed(segment.Distance.Value).Value;
        TotalFuel += _spaceship.Engine.StartFuelAmount +
                     (_spaceship.Engine.FuelContribution.Value * (segment.Distance.Value / 100));
    }
}