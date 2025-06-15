using UnityEngine;
using UnityEngine.UI;
public class ButtonSetup : MonoBehaviour
{
    public Button blossomButton;
    public GameObject dullArtifacts;

    void Start()
    {
        blossomButton.onClick.AddListener(() => dullArtifacts.SetActive(true));
    }

    
}
