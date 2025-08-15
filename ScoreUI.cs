using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private TMPro.TextMeshProUGUI scoreText;

    private void OnEnable()
    {
        player.OnScoreChanged += UpdateScoreText; // Subscribe to the score change event
        player.OnMaxScore += ScoreMax; // Subscribe to the max score event
    }
    private void OnDisable()
    {
        player.OnScoreChanged -= UpdateScoreText; // Unsubscribe from the score change event
        player.OnMaxScore -= ScoreMax; // Unsubscribe from the max score event
    }
    private void UpdateScoreText(int Score)
    {
        scoreText.text = $"Score: {Score}"; // Update the UI text with the new score
    }

    private void ScoreMax()
    {
        scoreText.text = "Score: Max"; // Update the UI text with the max score
    }
}
