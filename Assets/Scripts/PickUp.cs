using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Inventorycontrol Inventory;

    public GameObject PickedItem;
       void Start()
    {
        Inventory = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventorycontrol>();
        Debug.Log(Inventory.Slots.Length);
    }


   
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            for (int i = 0; i < Inventory.Slots.Length; i++)
            {
                if (Inventory.Taken[i] == true)
                {

                }

                else if (Inventory.Taken[i] == false)
                {
                    Instantiate(PickedItem, Inventory.Slots[i].transform, false);
                    Destroy(gameObject);
                    Inventory.Taken[i] = true;

                    return;
                }
            }
        }
    }
}
