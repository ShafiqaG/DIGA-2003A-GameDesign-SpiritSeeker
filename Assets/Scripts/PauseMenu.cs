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

    //Title: Make Your MAIN MENU Quickly! | Unity UI Tutorial For Beginners
    //Author: YouTube- Rehope Games
    //Date: 04 May 2025
    //Code Version: 6000.0.49f1 (LTS)
    //Availibility: https://www.youtube.com/watch?v=DX7HyN7oJjE
}
