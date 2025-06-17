using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour

{
    public float health;
    public float maxHealth=100f;
    public Image healthBar;
    private GameObject damageEffectPrefab;
    private GameObject healEffectPrefab;

    AudioManager audioManager;

    private void Awake()
    {
        audioManager=GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>(); //plays sound when player health is at 0
    }

    private bool isDead;

    public GameManager gameManager; //when player health is at 0 the death panel pops up

    
    void Start() //player starts with full health
    {
        maxHealth = health;
    }

    
    void Update()
    {
        healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);

        if (health <= 0 && !isDead) //when health is at 0 the player dies
        {
            isDead = true; //allows the game over function to only be called once 
            gameObject.SetActive(false); //makes player disappear when they die
            gameManager.gameOver(); //screen should pop up 
            audioManager.PlaySFX(audioManager.gameover);
            Debug.Log("Dead");

            //Title: Unity Player Health and Health Bar Tutorial
            //Author: YouTube- MoreBBlakeyyy
            //Date: 16 May 2025
            //Code Version: 6000.0.49f1 (LTS)
            //Availibility: https://www.youtube.com/watch?v=bRcMVkJS3XQ
        }
    }

    public void TakeDamage(float damage, Vector2 collisionPoint)
    {
        health -= damage;
        if (health <= 0)
        {
            health = 0;
            isDead = true;
            gameObject.SetActive(false);
            gameManager.gameOver();
            audioManager.PlaySFX(audioManager.gameover);
            Debug.Log("Dead");
        }
    }

    public void TakeDamage()
    {
        // Instantiate damage effect at player's position
        Instantiate(damageEffectPrefab, transform.position, Quaternion.identity);
    }

    public void Heal()
    {
        // Instantiate heal effect at player's position
        Instantiate(healEffectPrefab, transform.position, Quaternion.identity);
    }

    public void Heal(float amount, Vector2 collisionPoint)
    {
        health += amount;
        if (health > maxHealth)
        {
            health = maxHealth;
        }

     
    }
}
