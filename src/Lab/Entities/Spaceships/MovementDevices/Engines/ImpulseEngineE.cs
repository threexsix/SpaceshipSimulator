using System;
using Itmo.ObjectOrientedProgramming.Lab1.Enums;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.MovementDevices.Engines;

public class ImpulseEngineE : Engine
{
    private const int EImpulseSpeed = 10;
    private const int EImpulseStartFuelAmount = 100;
    private const int EImpulseFuelContribution = 250;
    private const int EImpulseAcceleration = 50;
    private const int AccelerationTimesLimit = 5;
    private const int AcceleratingPerAstronomicUnit = 100;
    private const MovementDeviceType EngineType = MovementDeviceType.ImpulseE;

    public ImpulseEngineE()
        : base(EImpulseFuelContribution, EImpulseStartFuelAmount, EImpulseSpeed, EngineType)
    {
        Acceleration = EImpulseAcceleration;
    }

    private AstronomicalUnit Acceleration { get; }

    public override AstronomicalUnit AverageSpeed(AstronomicalUnit distance)
    {
        if (distance == null)
            throw new ArgumentException("distance is null");
        int timesAccelerated = distance.Value / AcceleratingPerAstronomicUnit;
        if (timesAccelerated >= AccelerationTimesLimit)
            return Speed + (Acceleration * AccelerationTimesLimit);
        return Speed + (Acceleration * (distance / AcceleratingPerAstronomicUnit));
    }
}