using UnityEngine;
using UnityEngine.SceneManagement;

public class HowToPlay : MonoBehaviour
{
    public void PlayGame() //if player clicks the arrow level 1 will load
    {
        SceneManager.LoadSceneAsync("Level 1");
    }
}
