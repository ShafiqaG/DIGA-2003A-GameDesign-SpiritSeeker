using UnityEngine;

public class Rockknockback : MonoBehaviour
{
    public float knockbackPower = 20; //sets a knockback power, this was iterated to be softer and changed from 65 to 20
    public float knockbackDuration = 2; //sets a knockback duration

    private void OnCollisionEnter2D(Collision2D other) // references knockback function from movement script
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(Lurakamovement.instance.Knockback(knockbackDuration, knockbackPower,this.transform));
        }
    }
}
