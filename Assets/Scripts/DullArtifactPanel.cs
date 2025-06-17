using UnityEngine;

public class DullArtifactPanel : MonoBehaviour
{
    public GameObject panel;
    public void ClosePanel()
    {
        panel.SetActive(false);
    }
    //Opens and closes panel
    public void OpenPanel()
    {
        panel.SetActive(true);
    }
}
