using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Represents a class that handles button interactions in a game.
/// </summary>
public class Buttons : MonoBehaviour
{
    /// <summary>
    /// The GameObject representing the text tiles.
    /// </summary>
    public GameObject TextTiles;

    private bool dead;
    private int x;
    private int y;
    Transform parentOne;
    GameObject player;
    

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        parentOne = player.transform.Find("Panel");
    }

    /// <summary>
    /// Turns on the text tiles and performs win/lose condition check.
    /// </summary>
    public void TurnOnTiles()
    {
        TextTiles.SetActive(true);
        GameManager.Instance.superJuego.AddToQueue(x,y, parentOne);
        GameManager.Instance.superJuego.WinLoseCondition(x, y);
       
    }

    private void Update()
    {
        // TODO: Add any necessary logic for the update method.
    }

    /// <summary>
    /// Sets the coordinates based on the given index.
    /// </summary>
    /// <param name="index">The index used to calculate the coordinates.</param>
    public void SetCoords(int index)
    {
        x = index / 10;
        y = index % 10;
    }
}

