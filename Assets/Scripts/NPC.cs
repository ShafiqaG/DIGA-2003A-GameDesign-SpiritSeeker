using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections;
using Unity.VisualScripting;
public class NPC : MonoBehaviour, IInteractable 
{
    public NPCDialogue dialogueData;
    public GameObject dialoguePanel;
    public TMP_Text dialogueText, nameText;
    public Image portraitImage; //everything needed for the npc dialogue panel

    private int dialogueIndex;
    private bool isTyping, isDialogueActive;

    public bool CanInteract()
    {
        return !isDialogueActive; 
    }

    public void Interact()
    {
        if (dialogueData == null) //ends dialogue
            return;
        if (isDialogueActive) //allows dialohue to continue until it's over
        {
            NextLine();
        }
        else
        {
            StartDialogue();    
        }
    }

    void StartDialogue() //shows the dialogue panel with everything in it and starts the dialogue
    {
        isDialogueActive = true;
        dialogueIndex = 0;

        nameText.SetText(dialogueData.npcName);
        portraitImage.sprite = dialogueData.npcPortrait;

        dialoguePanel.SetActive(true);

        StartCoroutine(TypeLine()); 
    }

    void NextLine()
    {
        if (isTyping)
        {
            StopAllCoroutines();
            dialogueText.SetText(dialogueData.dialogueLines[dialogueIndex]);
            isTyping = false;
        }
        else if (++dialogueIndex< dialogueData.dialogueLines.Length)
        {
            StartCoroutine(TypeLine());
        }
        else
        {
            EndDialogue();
        }
           
    }    

    IEnumerator TypeLine()
    {
        isTyping= true;
        dialogueText.SetText("");

        foreach(char letter in dialogueData.dialogueLines[dialogueIndex])
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(dialogueData.typingSpeed); //allows time between dialogue sentences
        }

        isTyping = false;
        if(dialogueData.autoProgressLine.Length>dialogueIndex)
        {
            yield return new WaitForSeconds(dialogueData.autoProgressDelay);
            NextLine();
        }
    }

    public void EndDialogue() //ends the dialogue and hides the panel
    {
        StopAllCoroutines();
        isDialogueActive= false;
        dialogueText.SetText("");
        dialoguePanel.SetActive(false);
    }
}
