/// <summary>
/// The GameManager class manages the game logic.
/// </summary>
public class GameManager : MonoBehaviour
{
    /// <summary>
    /// An instance of the Board class.
    /// </summary>
    public Board superJuego = new Board();

    /// <summary>
    /// Reference to a Transform component.
    /// </summary>
    public Transform m_game2;

    /// <summary>
    /// Reference to a GameObject.
    /// </summary>
    private GameObject m_gameObject2;

    /// <summary>
    /// Singleton instance of GameManager.
    /// </summary>
    public static GameManager Instance;

    /// <summary>
    /// Called before the first frame update.
    /// </summary>
    void Start()
    {
        if (Instance != null)
            Destroy(this); // Destroy the current instance if GameManager already exists
        Instance = this; // Set the GameManager instance as this

        // Find the GameObject with the "GamePanel" tag
        m_gameObject2 = GameObject.FindGameObjectWithTag("GamePanel");
        // Assign the transform of m_gameObject2 to m_game2
        m_game2 = m_gameObject2.transform;

        // Generate the game board using the superJuego object
        superJuego.GenerateBoard();
    }

    /// <summary>
    /// Update is called once per frame.
    /// </summary>
    void Update()
    {
        // Code for updating the game goes here
    }

    /// <summary>
    /// Shows the array and logs "Hola" to the console.
    /// </summary>
    public void ShowArray()
    {
        Debug.Log("Hola"); // Output "Hola" to the console
        superJuego.PrintArray(); // Call the PrintArray method of the superJuego object
    }

    /// <summary>
    /// Sets bombs on the game board and turns off text tiles.
    /// </summary>
    public void BottumSetBombs()
    {
        superJuego.SetBombsTest(m_game2); // Set bombs on the game board using the SetBombsTest method of the superJuego object
        superJuego.TurnOffTextTile(m_game2); // Turn off text tiles using the TurnOffTextTile method of the superJuego object
    }
}

