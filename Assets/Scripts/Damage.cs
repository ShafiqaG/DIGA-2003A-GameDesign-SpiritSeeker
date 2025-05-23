using UnityEngine;

public class Damage : MonoBehaviour
{
    public PlayerHealth pHealth;
    public float damage;

    AudioManager audioManager;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>(); //plays a sound when the player obtains damage
    }
    private void OnCollisionEnter2D(Collision2D other) //when player collides with damageable object
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pHealth.health -= damage; //deals damage
            audioManager.PlaySFX(audioManager.losinghealth);
        }
    }
}
