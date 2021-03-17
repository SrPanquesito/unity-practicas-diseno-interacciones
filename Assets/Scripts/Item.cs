using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Item es el objeto intermediario para almacenar info acerca de un GameObject para guardar en Inventory.
// Intermediario entre objeto real en escena y objeto en el inventario
public enum ItemType
{
    Equip, Weapon, Medicine, Consumable
}

[CreateAssetMenu(fileName= "New Item", menuName= "Inventory/Generic")]

public class Item : ScriptableObject
{
    public ItemType itemType = ItemType.Equip;
    public Sprite icon = null;

    public virtual void Use()
    {
        Debug.Log($"Usando item {name}");
    }
}
