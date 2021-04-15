using UnityEngine;

public class DifficultyManager : MonoBehaviour
{
    public PointHandler score;
    public DestroyObject currentSpeed;
    void Update() {
        if (score.currentScore < 10) currentSpeed.speed = 3;
    // Speed up to 4    
        if (score.currentScore >= 10) currentSpeed.speed = 4;
    // Speed up to 5
        if (score.currentScore >= 30) currentSpeed.speed = 5;
    // Speed up to 6
        if (score.currentScore >= 50) currentSpeed.speed = 6;
    }
}
