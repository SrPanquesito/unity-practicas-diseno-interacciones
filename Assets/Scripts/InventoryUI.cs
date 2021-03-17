using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    private Inventory _inventory;
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        _inventory = Inventory.InventoryInstance;
        _inventory.onChange += UpdateUI; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            panel.SetActive(!panel.activeSelf);
            UpdateUI();
        }
    }

    void UpdateUI() 
    {
        Debug.Log("Cambio el inventario");
        Slot[] slots = GetComponentsInChildren<Slot>();
        Item[] consumableItems = _inventory.GetAllItemsByType(ItemType.Consumable);
        
        if (consumableItems.Length > 0)
            slots[0].SetItem(consumableItems[0], consumableItems.Length);

        // for (int i = 0; i < slots.Length; i++)
        // {

        //     if (i < _inventory.items.Count) 
        //     {
        //         slots[i].SetItem(_inventory.items[i]);
        //     }
        //     else
        //     {
        //         slots[i].Clear();
        //     }
        // }
    }
}
