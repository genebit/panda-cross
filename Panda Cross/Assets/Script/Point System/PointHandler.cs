using UnityEngine;
using TMPro;
public class PointHandler : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI inScoreGameOverPanel;
    [HideInInspector]
    public int currentScore;
    void Start() 
    {
        currentScore = 0;
    }
    void Update() 
    {
        scoreText.text = currentScore.ToString();
        inScoreGameOverPanel.text = currentScore.ToString();
    }
}
