using UnityEngine;

public class Rockknockback : MonoBehaviour
{
    public float knockbackPower = 20;
    public float knockbackDuration = 2;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(Lurakamovement.instance.Knockback(knockbackDuration, knockbackPower,this.transform));
        }
    }
}
