using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile
{
    public bool IsVisible { get; private set; }
    public bool FlagOn { get; private set; }

    public int BombsNear { get; private set; }
    public bool BomboN { get; private set; }

    public int BombCounter { get; private set; }

    
    public Tile(bool isBomb)
    {   
        BomboN = isBomb;
    }
    public void AddBombsNear()
    {
        BombsNear++;
    }

    public void Visible()
    {
        IsVisible= true;
    }

}
