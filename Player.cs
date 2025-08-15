using UnityEngine;
using System;
using UnityEngine.Events;
public class Player : MonoBehaviour
{
    public event Action<int> OnScoreChanged;
    public event Action OnMaxScore;

    public UnityEvent OnButtonPressed;

    public int score = 0;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Item"))
        {
            score += 10; // Increment score by 10 for each item collected
            OnScoreChanged?.Invoke(score); // Notify subscribers about the score change
            Destroy(collision.gameObject); // Destroy the item after collection
            if (score >= 40) // Check if score reaches max threshold
            {
                OnMaxScore?.Invoke(); // Notify subscribers about reaching max score
            }
        }
    }
    public void ButtonPressed()
    {
        OnButtonPressed?.Invoke(); // Invoke the button pressed event
    }
}
