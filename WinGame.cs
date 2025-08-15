using UnityEngine;


using System.Collections;

public class WinGame : MonoBehaviour
{
    [SerializeField] private GameObject winPanel; // Reference to the win panel UI

    void Awake()
    {
        winPanel.SetActive(false); // Ensure the win panel is inactive at the start
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Win"))
        {
            StartCoroutine(ShowWinPanel()); // Start the coroutine to show the win panel
        }
    }

    IEnumerator ShowWinPanel()
    {
        yield return new WaitForSeconds(2f); // Wait for 1 second before showing the win panel
        winPanel.SetActive(true);
        Time.timeScale = 0f; // Pause the game
    }
}
