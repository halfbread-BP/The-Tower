using System;
using Godot;

namespace Tt;

/// <summary>
/// base representation of a floor of the game, which is defined from a 2D array of tiles + a background and a unique mechanic
/// </summary>
public abstract partial class Floor : Node2D
{
    public string name { get; private set; }

    public float virtualWidth
    {
        get { return TheTower.Instance.visisbleX; }
    }
    public float virtualHeight
    { 
        get { return TheTower.Instance.visibleY; }
    }

    // in tiles
    public int width
    {
        get { return (int)(virtualWidth / Tile.width); }
    }
    public int height
    {
        get { return (int)(virtualHeight / Tile.height); }
    }

    public Tile[,] tileMap;

    public Floor(string name = "Floor ")
    {
        tileMap = new Tile[width, height];
    }
}