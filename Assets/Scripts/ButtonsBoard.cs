using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Brief description of the class or member.
/// </summary>
/// <remarks>
/// Additional remarks or details about the class or member.
/// </remarks>
public class ButtonsBoard : MonoBehaviour
{
    /// <summary>
    /// Reference to the button prefab.
    /// </summary>
    public Button button;

    private int numberTiles;
    public Transform parent;

    /// <summary>
    /// Initializes the number of tiles and generates them.
    /// </summary>
    void Start()
    {
        numberTiles = Board.boardRows * Board.boardColumns;

        GenerateTiles();
    }

    /// <summary>
    /// Generates the tiles and assigns coordinates to them.
    /// </summary>
    public void GenerateTiles()
    {
        for (int i = 0; i < numberTiles; i++)
        {
            Button temp = Instantiate(button, parent);

            if (!temp.TryGetComponent<Buttons>(out Buttons butt))
            {
                butt = temp.AddComponent<Buttons>();
            }

            butt.SetCoords(i);
        }
    }
}

