using Itmo.ObjectOrientedProgramming.Lab1.Enums;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.MovementDevices.Engines;

public abstract class Engine : MovementDevice
{
    protected Engine(Fuel fuelContribution, Fuel startFuelAmount, int speed, MovementDeviceType engineType)
        : base(speed, engineType)
    {
        FuelContribution = fuelContribution;
        StartFuelAmount = startFuelAmount;
    }

    public Fuel FuelContribution { get; }
    public Fuel StartFuelAmount { get; }

    public abstract AstronomicalUnit AverageSpeed(AstronomicalUnit distance);
}