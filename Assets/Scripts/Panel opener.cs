using UnityEngine;

public class Panelopener : MonoBehaviour
{

    public GameObject Panel;

    public void OpenPanel() //opens the panel 
    {
        if (Panel != null)
        {
            Panel.SetActive(true);
        }
    }

}
       
    


    

