using System;
using Itmo.ObjectOrientedProgramming.Lab1.Enums;
using Itmo.ObjectOrientedProgramming.Lab1.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.MovementDevices.JumpDrives;

public class OmegaDrive : JumpDrive
{
    private const int OmegaDriveMaxJump = 48000;
    private const MovementDeviceType JumpType = MovementDeviceType.OmegaDrive;
    public OmegaDrive()
        : base(OmegaDriveMaxJump, JumpType)
    {
    }

    public override Fuel MatterConsumption()
    {
        return new Fuel(BaseMatterContribution.Value * (int)Math.Log10(BaseMatterContribution.Value));
    }
}