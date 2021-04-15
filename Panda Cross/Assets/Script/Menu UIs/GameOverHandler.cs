using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverHandler : MonoBehaviour
{
    public GameObject pauseMenu;
    public PandaHurt health;
    public Animator animatorRetryButton, animatorHomeButton;
    void Update() 
    {
        if (health.currentHealth == 0) {
            pauseMenu.SetActive(false);
            GameOver(true);
        }
    }
    void GameOver(bool isGameOver) { //UI Animation-Panel enters screen
        this.GetComponentInChildren<Animator>().SetBool("GameOver", isGameOver);
    }
    public void Restart_Button() {
        animatorRetryButton.SetTrigger("IsPressed");
        Invoke("RestartGame", 0.25f);
    }
    void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Home_Button() {
        animatorHomeButton.SetTrigger("IsPressed");
        Invoke("GoBackHome", 0.25f);
    }
    void GoBackHome() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
