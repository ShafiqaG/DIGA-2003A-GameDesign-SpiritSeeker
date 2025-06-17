using UnityEngine;
using UnityEngine.SceneManagement;//switches scenes

public class IntoScene : MonoBehaviour
{
    public void PlayGame() //if player clicks the arrow How To Play will load
    {
        SceneManager.LoadSceneAsync("How To Play");
    }
}
