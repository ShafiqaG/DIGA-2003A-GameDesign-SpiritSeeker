using UnityEngine;
using UnityEngine.UI;

public class TabController : MonoBehaviour
{
    public Image[] tabImages;
    public GameObject[] pages;
    
    void Start()
    {
        ActivateTab(0);
    }

    public void ActivateTab(int tabNo)
    {
        for(int i = 0; i < pages.Length; i++)
        {
            pages[i].SetActive(false);
            tabImages[i].color = Color.grey; //turns the remaining tabs grey when selecting specific tab
        }
        pages[tabNo].SetActive(true);
        tabImages[tabNo].color = Color.white;

        ////Create a quest log with scroll and view and reactive layout (Game Code Library)
        //Accessed 13th June
    }

}
