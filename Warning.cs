using UnityEngine;
using TMPro;

public class Warring : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI warningText;
    [SerializeField] private PlayerCollision player;
    void OnEnable()
    {
        player.OnWarningEnemy_0 += ShowWarningEnemy0;
        player.OnWarningEnemy_1 += ShowWarningEnemy1;
        player.OnWarningNull += ShowWarningNull; // Subscribe to the null warning event
    }
    void OnDisable()
    {
        player.OnWarningEnemy_0 -= ShowWarningEnemy0;
        player.OnWarningEnemy_1 -= ShowWarningEnemy1;
        player.OnWarningNull -= ShowWarningNull; // Unsubscribe from the null warning event
    }
    private void ShowWarningEnemy0()
    {
        warningText.text = $"Warning: Enemy 0 approaching!";
        warningText.color = new Color(0.541176f, 0f, 0.713725f, 1f); // Set color to red for enemy 0 warning
    }
    private void ShowWarningEnemy1()
    {
        warningText.text = $"Warning: Enemy 1 approaching!";
        warningText.color = Color.red; // Set color to yellow for enemy 1 warning

    }
    private void ShowWarningNull()
    {
        warningText.text = $"Warning: Unknown entity detected!";
        warningText.color = Color.green; // Set color to yellow for unknown entity warning
    }

}
