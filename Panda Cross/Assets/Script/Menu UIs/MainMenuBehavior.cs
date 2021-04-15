using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuBehavior : MonoBehaviour
{
    public Animator transition;
    public void Play() {
        transition.SetTrigger("Exit Transition");
        Invoke("LoadGameScene", 0.70f);
    }
    void LoadGameScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void CloseGame() {
        Debug.Log("Quiting Game...");
        Application.Quit();
    }
}
