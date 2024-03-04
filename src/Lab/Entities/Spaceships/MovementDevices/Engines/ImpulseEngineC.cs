using Itmo.ObjectOrientedProgramming.Lab1.Enums;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.MovementDevices.Engines;

public class ImpulseEngineC : Engine
{
    private const int СImpulseSpeed = 50;
    private const int СImpulseStartFuelAmount = 100;
    private const int CImpulseFuelContribution = 90;
    private const MovementDeviceType EngineType = MovementDeviceType.ImpulseC;
    public ImpulseEngineC()
        : base(CImpulseFuelContribution, СImpulseStartFuelAmount, СImpulseSpeed, EngineType) { }

    public override AstronomicalUnit AverageSpeed(AstronomicalUnit distance)
    {
        return Speed;
    }
}