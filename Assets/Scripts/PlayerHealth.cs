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
        audioManager=GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    private bool isDead;

    public GameManager gameManager;
    
    void Start()
    {
        maxHealth = health;
    }

    
    void Update()
    {
        healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);

        if (health <= 0 && !isDead)
        {
            isDead = true; //allows the game over function to only be called once 
            gameObject.SetActive(false); //makes player disappear when they die
            gameManager.gameOver(); //screen should pop up 
            audioManager.PlaySFX(audioManager.gameover);
            Debug.Log("Dead");
        }
    }
}
