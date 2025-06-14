using UnityEngine;

public class ArtifactPanel : MonoBehaviour
{
    public GameObject Artifact;
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Artifact"))
        {
            Artifact.SetActive(true);
           
        }
    }
  
}
