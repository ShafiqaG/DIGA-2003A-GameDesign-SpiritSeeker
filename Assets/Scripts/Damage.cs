using Unity.VisualScripting;
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


            //Title: Apply Damage and Knockback to Enemies or Players in Unity 2022 2D Action RPG Tutorial
            //Author: YouTube-Chris' Tutorials
            //Date: 16 May 2025
            //Code Version: 6000.0.49f1 (LTS)
            //Availibility: https://www.youtube.com/watch?v=bRcMVkJS3XQ
        }
    }
}
