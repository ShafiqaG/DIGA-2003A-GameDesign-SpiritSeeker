using UnityEngine;

public class QuestLogMenuController : MonoBehaviour
{
    public GameObject questlogmenuCanvas;
   
    void Start()
    {
        questlogmenuCanvas.SetActive(true); //ensures the quest log menu is closed when the game starts 
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) //button that opens menu
        {
            questlogmenuCanvas.SetActive(!questlogmenuCanvas.activeSelf);
        }
    }
} 
