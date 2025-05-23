using UnityEngine;
using UnityEngine.SceneManagement;//switches between scenes

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Intro Scene"); //start = play the intro scene
    }

    public void QuitGame() //quit = leave the game
    { 
        Application.Quit();
    }
    
}
