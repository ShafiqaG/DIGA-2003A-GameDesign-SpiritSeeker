using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("---------- Audio Source ----------")]
    [SerializeField] AudioSource musicSource; //component that allows audio to play
    [SerializeField] AudioSource SFXSource; //seperates the sound effects and the background audios

    [Header("---------- Audio Clip ----------")]
    public AudioClip startmenu; //keeps the sounds 
    public AudioClip gamestart;
    public AudioClip level1;
    public AudioClip collectingwater;
    public AudioClip clickingui;
    public AudioClip losinghealth;
    public AudioClip cracklingcampfire;
    public AudioClip walking;
    public AudioClip gameover;
    public AudioClip level2unlocked;
    public AudioClip RegainingHealth;
    public AudioClip Congratulations;

    private void Start()
    {
        musicSource.clip = level1; //play when level 1 starts
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip) //public void allows it to be used and referenced in other scripts
    {
        SFXSource.PlayOneShot(clip);
    }
}
