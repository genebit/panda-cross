using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PauseMenu : MonoBehaviour
{
    [Header("Controls")]
    public GameObject touchControls;
    public Button skillControls;
    public bool isEnabled;

    [Header("Buttons")]
    [SerializeField] private GameObject pause;
    [SerializeField] private GameObject resume;
    [SerializeField] private GameObject home;

    public void PauseGame() 
    {
        isEnabled = false;
        touchControls.SetActive(isEnabled);
        skillControls.interactable = isEnabled;
        
        Time.timeScale = 0f;
        
        pause.SetActive(false);
        resume.SetActive(true);
        home.SetActive(true);
    }
    public void ResumeGame() 
    {
        isEnabled = true;
        touchControls.SetActive(isEnabled);
        skillControls.interactable = isEnabled;

        Time.timeScale = 1f;
        
        pause.SetActive(true);
        resume.SetActive(false);
        home.SetActive(false);
    }
    public void GoToMainMenu() 
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }
}
