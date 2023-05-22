using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : GameManager
{
    public GameObject TextTiles;
    bool dead;
    public void TurnOnTiles()
    {
        TextTiles.SetActive(true);
       // dead = superJuego.tile[,].BomboN;
    }

    private void Update()
    {
        
    }
}
