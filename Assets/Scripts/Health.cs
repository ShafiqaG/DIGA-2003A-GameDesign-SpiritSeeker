using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{ 
    public PlayerHealth PlayerHealth;
    public float healAmount = 20f;    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(UsePotion);
    }

    public void UsePotion()
    {
        PlayerHealth.Heal(healAmount); 
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
