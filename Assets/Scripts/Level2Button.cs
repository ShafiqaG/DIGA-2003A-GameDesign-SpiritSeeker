using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Button : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Congratulations"); //Loads congratulations scene
    }
}
