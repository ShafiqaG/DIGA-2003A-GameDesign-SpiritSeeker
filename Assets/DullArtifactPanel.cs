using UnityEngine;

public class DullArtifactPanel : MonoBehaviour
{
    public GameObject panel;
    public void ClosePanel()
    {
        panel.SetActive(false);
    }
}
