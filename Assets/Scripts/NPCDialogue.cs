using UnityEngine;


[CreateAssetMenu(fileName ="NewNPCDialogue", menuName ="NPC")]
public class NPCDialogue : ScriptableObject 
{
    public string npcName;
    public Sprite npcPortrait;
    public string[] dialogueLines;
    public bool[] autoProgressLine;
    public float autoProgressDelay = 1.5f;
    public float typingSpeed = 0.05f;
    internal object autoProgressLines;
}
      //all the elements needed for the NPC dialogue