using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public PlayerHealth pHealth;
    public float healAmount = 20f;

    AudioManager audioManager;

    void Start()
    {

    }


    void Update()
    {

    }

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>(); //plays a sound when the player regains health
    }
    private void OnCollisionEnter2D(Collision2D other) //when player collides with healing potion object
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pHealth.health += healAmount; //heals
            audioManager.PlaySFX(audioManager.RegainingHealth);
        }
    }

} // referenced the damage script code and changed the condition, no additional external sources used. 
        
