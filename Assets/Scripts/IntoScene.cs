using UnityEngine;
using UnityEngine.SceneManagement;//switches scenes

public class IntoScene : MonoBehaviour
{
    public void PlayGame() //if player clicks the arrow level 1 will load
    {
        SceneManager.LoadSceneAsync("Level 1");
    }
}
