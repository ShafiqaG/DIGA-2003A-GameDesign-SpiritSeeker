using System;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Inventorycontrol Inventory;
    public GameObject PickedItem;

    public GameObject inventoryPanel;


    AudioManager audioManager;

    public static Inventorycontrol Instance {  get; private set; }
    Dictionary<int, int> itemsCountCache = new();
    public event Action OnInventoryChanged; //notifies the quest system 
   


       void Start()
    {
        Inventory = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventorycontrol>(); //collects the items
        Debug.Log(Inventory.Slots.Length);

        RebuildItemCounts();
    }

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>(); //plays a sound whenever the item is collected
    }

    public void RebuildItemCounts()
    {
        itemsCountCache.Clear();
        foreach(Transform slotTransform in inventoryPanel.transform)
        {
            Slot slot = slotTransform.GetComponent<Slot>();
            if (slot.currentItem != null)
            {
                Item item = slot.currentItem.GetComponent<Item>();
                if (item != null)
                {
                    itemsCountCache[item.ID] = itemsCountCache.GetValueOrDefault(item.ID, 0) + 1;
                }
            }
        }

        OnInventoryChanged?.Invoke();

    }

    public Dictionary<int, int>GetItemCounts() => itemsCountCache;

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        {
            for (int i = 0; i < Inventory.Slots.Length; i++)
            {
                if (Inventory.Taken[i]==true)
                {
                    
                }

                else if (Inventory.Taken[i] == false)
                {
                    Instantiate(PickedItem, Inventory.Slots[i].transform, false); //adds it to the inventory
                    audioManager.PlaySFX(audioManager.collectingwater); //plays the sound
                    Destroy(gameObject); //destroys the cacti on the scene
                    Inventory.Taken[i] = true;

                    RebuildItemCounts();

                    return; //makes sure that all slots get filled instead of just one

                    //Title: How To Make An Inventory In Unity P1/2 - Unity Tutorial
                    //Author: YouTube- The Game Smith
                    //Date: 16 May 2025
                    //Code Version: 6000.0.49f1 (LTS)
                    //Availibility: https://www.youtube.com/watch?v=XzeEqEb-0Ec
                }

            }
           
        }
    }
}
