using UnityEngine;

public class DullArtifact : MonoBehaviour
{
    public GameObject DullArtifacts;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Dull Artifact"))
        {
            DullArtifacts.SetActive(true);

        }
    }
}
