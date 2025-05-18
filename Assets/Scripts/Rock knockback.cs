using UnityEngine;

public class Rockknockback : MonoBehaviour
{
    public float knockbackPower = 65;
    public float knockbackDuration = 3;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(Lurakamovement.instance.Knockback(knockbackDuration, knockbackPower,this.transform));
        }
    }
}
