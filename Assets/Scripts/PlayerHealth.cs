using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour

{
    public float health;
    public float maxHealth;
    public Image healthBar;

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
        }
    }
}
