using UnityEngine;


[CreateAssetMenu(fileName ="NewNPCDialogue", menuName ="NPC")]
public class NPCDialogue : ScriptableObject 
{
    public string npcName;
    public Sprite npcPortrait;
    public string[] dialogueLines;
    public bool[] autoProgressLine;
    public bool[] endDialogueLines;
    public float autoProgressDelay = 1.5f;
    public float typingSpeed = 0.05f;
    internal object autoProgressLines;

    public DialogueChoice[] choices;
}
//all the elements needed for the NPC dialogue

[System.Serializable]

public class DialogueChoice
{
    public int dialogueIndex; //shows the dialogue choices 
    public string[] choices; //response options
    public int[] nextDialogueIndexes; //the choice branch and outcome
}

//Title: Add NPC and Dialogue System to your Game - Top Down Unity 2D #19
//Author: YouTube- Game Code Library
//Date: 16 May 2025
//Code Version: 6000.0.49f1 (LTS)
//Availibility: https://www.youtube.com/watch?v=eSH9mzcMRqw