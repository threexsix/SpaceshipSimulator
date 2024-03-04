using Itmo.ObjectOrientedProgramming.Lab1.Enums;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.MovementDevices.JumpDrives;

public class AlphaDrive : JumpDrive
{
    private const int AlphaDriveMaxJump = 12000;
    private const MovementDeviceType JumpType = MovementDeviceType.AplhaDrive;
    public AlphaDrive()
        : base(AlphaDriveMaxJump, JumpType)
    {
    }

    public override Fuel MatterConsumption()
    {
        return BaseMatterContribution;
    }
}