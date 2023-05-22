using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsBoard : MonoBehaviour
    
{
    public Button button;
    private int numberTiles;
    public Transform parent;
   

    void Start()
    {
      numberTiles = Board.boardRows * Board.boardColumns;
     
      generateTiles();
    }

    public void generateTiles()
    {
        for (int i = 0; i < numberTiles; i++)
        {
           
            Instantiate(button,parent);
        }
    }

   

}
