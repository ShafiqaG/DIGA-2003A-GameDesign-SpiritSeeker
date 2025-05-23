using UnityEngine;

public class WaterPanelNotification : MonoBehaviour
{
    public GameObject Panel;
   
    public void OpenPanel() //opens panel on button click
    {
        if(Panel != null) //allows panel to open and close on button click
        {
            bool isActive = Panel.activeSelf; 
            Panel.SetActive(!isActive); 
        }
    }
}
