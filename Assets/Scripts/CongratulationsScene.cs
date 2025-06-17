using UnityEngine;
using UnityEngine.SceneManagement;

public class CongratulationsScene : MonoBehaviour
{
    public void PlayGame() //if player clicks the arrow level 2 will load
    {
        SceneManager.LoadSceneAsync("Level 2");

    }

}
