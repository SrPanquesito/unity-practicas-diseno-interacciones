using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// añadir objeto al inventario
public class PickupObject : Interactable
{
    public Item item;

    public override void Interact() 
    {
        this.gameObject.SetActive(false);
        Inventory.InventoryInstance.Add(item);
    }
}
