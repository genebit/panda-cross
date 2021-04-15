using UnityEngine;

public class TriggerPoints : MonoBehaviour
{
    public PandaHurt healthState;
    public PointHandler score;
    public Animator scoreAnimator;
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Ladybug" && healthState.currentHealth != 0) {
            score.currentScore++;
            scoreAnimator.SetTrigger("AddPoints");
            SoundManager.PlaySound("AddPoints");
        }
    }
}
