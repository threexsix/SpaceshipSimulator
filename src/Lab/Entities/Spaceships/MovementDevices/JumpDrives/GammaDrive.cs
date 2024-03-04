using Itmo.ObjectOrientedProgramming.Lab1.Enums;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.MovementDevices.JumpDrives;

public class GammaDrive : JumpDrive
{
    private const int GammaDriveMaxJump = 24000;
    private const MovementDeviceType JumpType = MovementDeviceType.GammaDrive;
    public GammaDrive()
        : base(GammaDriveMaxJump, JumpType)
    {
    }

    public override Fuel MatterConsumption()
    {
        return BaseMatterContribution * BaseMatterContribution;
    }
}