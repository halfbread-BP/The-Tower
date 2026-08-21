using System;
using System.Collections.Generic;
using Godot;

namespace Tt;

public sealed class FloorManager
{
    public int Floor1
    {
        get { return 0; }
    }
    public int Floor2
    {
        get { return 1; }
    }
    public int Floor3
    {
        get { return 2; }
    }
    public int Floor4
    {
        get { return 3; }
    }

    private List<Floor> _floors = [];
    public IReadOnlyList<Floor> floors
    {
        get { return _floors; }
    }

    internal FloorManager()
    {
        _floors.Add(TheTower.Instance.GetNode<Floor>("1st Floor"));
    }
}