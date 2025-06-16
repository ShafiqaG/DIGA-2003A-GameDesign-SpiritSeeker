using UnityEngine;

public class WaterOrbs : MonoBehaviour
{
    public GameObject WaterOrb;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Water Orb"))
        {
            WaterOrb.SetActive(true);

        }
    }
}
