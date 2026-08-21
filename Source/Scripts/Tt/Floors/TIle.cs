using System;
using Godot;

namespace Tt;

/// <summary>
/// Represents a tile in 2D space.
/// </summary>
public sealed class Tile
{
    public static int width { get; private set; } = 16;
    public static int height { get; private set; } = 16;
}