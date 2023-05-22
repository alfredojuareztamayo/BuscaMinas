using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Board 
{
    Stack<Tile> Bombitas = new();
    public const int boardRows = 10;
    public const int boardColumns = 10;
    public Tile[,] tile  = new Tile[boardRows, boardColumns];
    public int BombNum { get; private set; } = 20;

    //tempBomb=10              tilesLeft=10  random=rand :V jaj
    public void GenerateBoard()
    {
        int tempBomb = BombNum;
        int tilesLeft = boardColumns * boardRows;
      
        for (int i = 0; i < boardRows; i++)
        {
            for (int j = 0; j < boardColumns; j++)
            {
                int random = Random.Range(0, 5);
                if(tilesLeft == tempBomb)
                {
                    tile[i, j] = new Tile(true);
                    tempBomb--;
                    tilesLeft--;
                }
                else
                {
                    if (tempBomb > 0 & random == 1)
                    {
                        tile[i, j] = new Tile(true);
                        tempBomb--;
                        tilesLeft--;
                    }
                    else
                    {
                        tile[i, j] = new Tile(false);
                       
                        tilesLeft--;
                    }
                }
                
            }
        }

        AddToStack();
    }

    public void PrintArray()
    {
        string printArray = " ";
        for (int i = 0; i < boardRows; i++)
        {
            for (int j = 0; j < boardColumns; j++)
            {
               if(tile[i, j].BomboN)
                {
                    printArray += 'B';
                }
                else
                {
                    printArray += tile[i, j].BombsNear;
                }
                printArray += ',';
            }
            printArray += '\n';
        }
        Debug.Log(printArray);
    }

    public void AddToStack()
    {
        for (int i = 0; i < boardRows; i++)
        {
            for (int j = 0; j < boardColumns; j++)
            {
                if (!tile[i, j].BomboN ) continue;
                Checksurroundind(i, j);
                
            }
        }
    }
    public void Checksurroundind(int i, int j)
    {
        for (int x = i-1; x <= i +1 ; x++)
        {
            for (int y = j-1; y <= j+1 ; y++)
            {
                if (x < 0) continue;
                if(y < 0) continue;
                if(x >= boardColumns) continue;
                if(y >= boardRows) continue;
                if (tile[x, y].BomboN) continue;
                Bombitas.Push(tile[x, y]);
                tile[x, y].Visible();
            }
        }
        AddCounterBombs();
    }
    public void AddCounterBombs()
    {
        while(Bombitas.Count > 0)
        {
            Bombitas.Pop().AddBombsNear();

        }     
    }
    public void SetBombsTest(Transform parent)
    {
        TMP_Text m_text;
        int k = 0;
        Transform p = parent;
        

        for (int i = 0; i < boardRows; i++)
        {
            for (int j = 0; j < boardColumns; j++)
            {
              // m_text = p.GetChild(k).GetComponent<TMP_Text>();
               
                m_text = p.GetChild(k).GetComponentInChildren<TMP_Text>();
               
               // Debug.Log(m_text);

                if (tile[i, j].BomboN)
                {
                   // Debug.Log("Entre en la primera");
                    m_text.text = "B";
                   
                }
                else
                {
                   // Debug.Log("Entre en la seg");
                    m_text.text = tile[i, j].BombsNear.ToString();
                   
                }
                k++;
            }
           
        }
       
    }
    public void TurnOffTextTile(Transform parent)
    {
        GameObject g;
        foreach (Transform child in parent)
        {
            g = child.Find("TextTag").gameObject;
            g.SetActive(false);
        }
    }

}
