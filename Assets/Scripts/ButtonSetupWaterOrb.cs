using UnityEngine;
using UnityEngine.UI;

public class ButtonSetupWaterOrb : MonoBehaviour
{
    public Button waterorbButton;
    public GameObject WaterOrb;

    void Start()
    {
       if (waterorbButton != null && WaterOrb != null)
        {
            waterorbButton.onClick.AddListener(OpenPanel); //opens panel on click
        }
    }
    void OpenPanel()
    {
        WaterOrb.SetActive(true);
    }
}
