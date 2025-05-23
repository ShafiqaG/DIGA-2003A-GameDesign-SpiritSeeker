using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement; //allows scene to be switched 
public class GameManager : MonoBehaviour
{
    public GameObject gameOverUI;
    void Start()
    {
    }

    void Update()
    {
        
    }

    public void gameOver()
    {
        gameOverUI.SetActive(true); //makes the panel visible
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //if restart button is pressed, the scene will reload

        //Title: Game Over Screen Unity Tutorial
        //Author: YouTube- MoreBBlakeyyy
        //Date: 16 May 2025
        //Code Version: 6000.0.49f1 (LTS)
        //Availibility: https://www.youtube.com/watch?v=pKFtyaAPzYo
    }

    public void quit()
    {
        Application.Quit(); //if quit button is pressed then the game stops 
    }
}


