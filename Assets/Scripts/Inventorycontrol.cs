using System;
using System.Collections.Generic;
using UnityEngine;

public class Inventorycontrol : MonoBehaviour
{
    public GameObject Inventory;
    public GameObject[] Slots;

    public bool[] Taken;
   
    public void OpenInventory() //shows the inventory
    {
        Inventory.SetActive(!Inventory.activeSelf);
    }

    
}
