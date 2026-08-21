using System;
using Godot;

namespace Tt;

/// <summary>
/// Singleton that holds the game.
/// </summary>
public sealed partial class TheTower : Node2D
{
	public static TheTower Instance { get; private set; }
	public static FloorManager floorManager { get; private set; }

	public const string GAME_VERSION = "0.1.0";

	public float FPS
	{
		get { return (float)Engine.GetFramesPerSecond(); }
	}

	public Camera2D camera { get; private set; }

	public Viewport viewport { get; private set; }
	public Rect2 visibleRect
	{
		get { return (Rect2)viewport?.GetVisibleRect(); }
	}
	public Vector2 visisbleSize
	{
		get { return (Vector2)viewport?.GetVisibleRect().Size; }
	}
	public float visisbleX
	{
		get { return (float)viewport?.GetVisibleRect().Size.X; }
	}
	public float visibleY
	{
		get { return (float)viewport?.GetVisibleRect().Size.Y; }
	}

	public Node2D floor1 { get; private set; }

	private TheTower()
	{ }

	public override void _EnterTree()
	{
		Instance = this;
		floorManager = new();
	}

	public override void _Ready()
	{
		camera = GetNode<Camera2D>("Camera");
		viewport = camera.GetViewport();
		floor1 = GetNode<Node2D>("1st Floor");
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
		Instance = null!;
		floorManager = null!;
	}

	public static ImageTexture CreateSimpleImageTexture(int width = 20, int height = 20, bool useMipmaps = false, Image.Format format = Image.Format.Rgba8, Color? color = null)
	{
		color ??= Color.Color8(255, 255, 255, 255); // default to white

		ImageTexture image;

		Image texture = Image.CreateEmpty(width, height, useMipmaps, format);
		texture.Fill((Color)color);

		image = ImageTexture.CreateFromImage(texture);
		return image;
	}
}
