using Itmo.ObjectOrientedProgramming.Lab1.Enums;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.MovementDevices.JumpDrives;

public abstract class JumpDrive : MovementDevice
{
    private const int JumpDriveSpeed = 1000;
    private const int JumpDriveMatterContribution = 100;
    protected JumpDrive(AstronomicalUnit distance, MovementDeviceType jumpType)
        : base(JumpDriveSpeed, jumpType)
    {
        Distance = distance;
        BaseMatterContribution = JumpDriveMatterContribution;
    }

    public AstronomicalUnit Distance { get; }
    public Fuel BaseMatterContribution { get; }

    public abstract Fuel MatterConsumption();
}