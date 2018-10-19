
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

    public GameObject MainMenu, BeatsMenu;

	public void Startgame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void StartBeatsMenu()
    {
        MainMenu.SetActive(false);
        BeatsMenu.SetActive(true);
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
