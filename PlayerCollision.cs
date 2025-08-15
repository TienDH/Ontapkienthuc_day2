using UnityEngine;
using System;
public class PlayerCollision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public event Action OnWarningEnemy_0;
    public event Action OnWarningEnemy_1;
    public event Action OnWarningNull;

    private bool isWarningEnemy = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy_0"))
        {
            OnWarningEnemy_0?.Invoke(); // Notify subscribers about the enemy 0 warning
            Debug.Log("Enemy 0 detected!"); // Optional: Log for debugging
            isWarningEnemy = true; // Set the warning flag
        }
        else if (collision.CompareTag("Enemy_1"))
        {
            OnWarningEnemy_1?.Invoke(); // Notify subscribers about the enemy 1 warning
            Debug.Log("Enemy 1 detected!"); // Optional: Log for debugging
            isWarningEnemy = true; // Set the warning flag
        }
    }
    void Update()
    {
        if (!isWarningEnemy)
        {
            OnWarningNull?.Invoke(); // Notify subscribers about the null warning
            isWarningEnemy = true; // Reset the warning flag
        }
    }
}
