using Itmo.ObjectOrientedProgramming.Lab1.Enums;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.MovementDevices;

public abstract class MovementDevice
{
    protected MovementDevice(AstronomicalUnit speed, MovementDeviceType movementType)
    {
        Speed = speed;
        MovementType = movementType;
    }

    public MovementDeviceType MovementType { get; }
    public AstronomicalUnit Speed { get; }
}