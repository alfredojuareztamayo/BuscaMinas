using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Board superJuego = new Board();
    public Transform m_game2;
    private GameObject m_gameObject2;
  
    void Start()
    {
        m_gameObject2 = GameObject.FindGameObjectWithTag("GamePanel");
        m_game2 = m_gameObject2.transform;
        superJuego.GenerateBoard();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowArray()
    {
        Debug.Log("Hola");
        superJuego.PrintArray();
    }
    public void bottumSetBombs()
    {
        superJuego.SetBombsTest(m_game2);
        superJuego.TurnOffTextTile(m_game2);
    }

    
   
}
