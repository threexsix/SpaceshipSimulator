using Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.Hulls;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.MovementDevices.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships.MovementDevices.JumpDrives;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Spaceships;

public abstract class Spaceship
{
    protected Spaceship(Engine engine, JumpDrive? jumpDrive, Deflector? deflector, Hull hull, bool hasNeutriumEmitter)
    {
        Engine = engine;
        JumpDrive = jumpDrive;
        Deflector = deflector;
        Hull = hull;
        HasNeutriumEmitter = hasNeutriumEmitter;
    }

    public Engine Engine { get; private set; }
    public JumpDrive? JumpDrive { get; private set; }
    public Deflector? Deflector { get; private set; }
    public Hull Hull { get; private set; }
    public bool HasNeutriumEmitter { get; private set; }
}