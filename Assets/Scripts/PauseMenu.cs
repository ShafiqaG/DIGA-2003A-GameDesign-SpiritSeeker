using JetBrains.Annotations;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    public void Pause() //pause menu pops up when pause buttom is pressed
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Resume() //pause panel closes
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void QuitGame() //exits game
    {
        Application.Quit();
    }
   
}
