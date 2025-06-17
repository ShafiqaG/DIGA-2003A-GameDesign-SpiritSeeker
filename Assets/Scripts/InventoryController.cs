using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using Unity.VisualScripting.Antlr3.Runtime;

public class InventoryController : MonoBehaviour
{
    //public GameObject inventoryPanel, (removed code)
    public GameObject slotPrefab;
    public int slotCount;
    public GameObject[] itemPrefabs;

    public static InventoryController Instance {  get; private set; }
    Dictionary<int, int> itemsCountCache = new();
    public event Action OnInventoryChanged;

    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }
    void Start()
    {
       // for (int i = 0; i < slotCount; i++)
        {
           // Slot slot = Instantiate(slotPrefab, inventoryPanel.transform).GetComponent<Slot>();
            //if(i < itemPrefabs.Length)
            {
               // GameObject item = Instantiate(itemPrefabs[i], slot.transform);
               // item.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
               // slot.currentItem = item;
                RebuildItemCounts();
            }
        }
    }

    public void RebuildItemCounts()
    {
        itemsCountCache.Clear();

       // foreach(Transform slotTransform in inventoryPanel.transform)
        {
           // Slot slot = slotTransform.GetComponent<Slot>();
            //if(slot.currentItem != null)
            {
              //  Item item = slot.currentItem.GetComponent<Item>();
              //  if (item != null)
                {
                 //   itemsCountCache[item.ID] = itemsCountCache.GetValueOrDefault(item.ID, 0) + item.quantity;
                }
            }
        }
        OnInventoryChanged?.Invoke();
    }

    public Dictionary<int, int>GetItemCounts() => itemsCountCache;

    public bool AddItem(GameObject itemPrefab)
    {
        //foreach(Transform slotTransform in inventoryPanel.transform)
        {
           // Slot slot = slotTransform.GetComponent<Slot>();
           // if (slot != null && slot.currentItem == null)
            {
               // GameObject newItem = Instantiate(itemPrefab, slotTransform);
              //  newItem.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
               // slot.currentItem = newItem;
                RebuildItemCounts();
                return true;
                
            }
        }
       // Debug.Log("Inventory is full");
       // return false;

        //this script is used as a backup inventory script in case the original inventory causes problems again

        //Drag and Drop Inventory UI- Top Down 2D (Game Code Library)
        //Accessed 13th June
    }
    

    

   
}
