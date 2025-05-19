using UnityEngine;
using UnityEngine.SceneManagement;

public class IntoScene : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Level 1");
    }
}
