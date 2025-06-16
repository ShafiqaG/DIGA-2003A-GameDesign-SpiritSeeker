using UnityEngine;

public class ScrollArtifact : MonoBehaviour
{
    public GameObject Scroll;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Scroll"))
        {
            Scroll.SetActive(true);

        }
    }
}
