using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Route;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships;
using Itmo.ObjectOrientedProgramming.Lab1.Enums;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services;

public class CollisionHandlerService
{
    private readonly Spaceship _spaceship;

    public CollisionHandlerService(Spaceship spaceship)
    {
        _spaceship = spaceship;
        IsCrewAlive = true;
        IsDestroyed = false;
        CurrentHp = _spaceship.Hull.ObjectStrengths;
        if (_spaceship.Deflector != null)
        {
            CurrentHp += _spaceship.Deflector.ObjectStrengths;
        }
    }

    public ObjectStrength CurrentHp { get; private set; }
    public bool IsDestroyed { get; private set; }
    public bool IsCrewAlive { get; private set; }

    public ExitCodes Handle(Segment segment)
    {
        if (segment == null)
            throw new ArgumentException("segment passed to CollisionHandlerService is null");
        ObjectStrength totalDmg = 0;

        foreach (Obstacle obstacle in segment.Environment.ContainedObstacles)
        {
            if (obstacle is Whale && _spaceship.HasNeutriumEmitter)
            {
                continue;
            }

            if (obstacle is Flash && (_spaceship.Deflector == null || _spaceship.Deflector.IsPhoton == false))
            {
                IsCrewAlive = false;
                return ExitCodes.CrewDead;
            }

            if (_spaceship.Deflector != null && obstacle is Flash)
            {
                if (!_spaceship.Deflector.CounterFlash())
                {
                    return ExitCodes.CrewDead;
                }
            }

            totalDmg += (int)obstacle.Damage;
        }

        if (CurrentHp > totalDmg)
        {
            CurrentHp -= totalDmg;
        }
        else
        {
            IsDestroyed = true;
            return ExitCodes.Destroyed;
        }

        if (!IsDestroyed && IsCrewAlive)
            return ExitCodes.Succeeded;
        return ExitCodes.Succeeded;
    }
}