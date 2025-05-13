using UnityEngine;

public class Inventorycontrol : MonoBehaviour
{
    public GameObject Inventory;
    public GameObject[] Slots;

    public bool[] Taken;

    public void OpenInventory()
    {
        Inventory.SetActive(!Inventory.activeSelf);
    }
}
