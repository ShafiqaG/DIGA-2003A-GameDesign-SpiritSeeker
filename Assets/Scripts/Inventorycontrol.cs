using System;
using System.Collections.Generic;
using UnityEngine;

public class Inventorycontrol : MonoBehaviour
{
    public GameObject Inventory;
    public GameObject[] Slots;

    public bool[] Taken;
    internal Action OnInventoryChanged;

    public void OpenInventory() //shows the inventory
    {
        Inventory.SetActive(!Inventory.activeSelf);
    }

    internal Dictionary<int, int> GetitemCounts()
    {
        throw new NotImplementedException();
    }
}
