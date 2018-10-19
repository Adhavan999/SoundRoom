using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public static bool ispaused = false;
    public GameObject PauseMenuUI, GUIHUD;

    private void Start()
    {
        PauseMenuUI.SetActive(false);
    }

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (ispaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }

        }
	}

    public void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        ispaused = true;
        GUIHUD.SetActive(false);
    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        ispaused = false;
        GUIHUD.SetActive(true);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0); //Loads the MainMenu scene
    }

    
}
