using System;
using Godot;

namespace Tt;

/// <summary>
/// Singleton that holds the game.
/// </summary>
public sealed partial class TheTower : Node2D
{
	public static TheTower instance { get; private set; }

	public const string GAME_VERSION = "0.1.0";

    public override void _EnterTree()
    {
        
    }

	public override void _Ready()
	{
		
	}

	public override void _Process(double delta)
	{
		
	}

    public override void _PhysicsProcess(double delta)
    {
        
    }

    public override void _Input(InputEvent @event)
    {
        
    }

    public override void _ExitTree()
    {
        
    }
}