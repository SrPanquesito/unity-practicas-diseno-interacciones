using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Inventory : MonoBehaviour
{
    // Singleton static Inventory
    static protected Inventory s_InventoryInstance;
    static public Inventory InventoryInstance {get {return s_InventoryInstance;}}

    public delegate void OnChange();
    public OnChange onChange;

    public int space = 10;
    public List<Item> items = new List<Item>();

    // Regresa un objeto inventario unico
    void Awake() 
    {
        s_InventoryInstance = this;
    }

    public Item[] GetAllItemsByType(ItemType type) 
    {
        return items.Where(i => i.itemType == type).ToArray();
    }

    public void Add(Item item) 
    {
        if (items.Count < space) 
        {
            // if (item.GetType() == typeof(Mushroom))
            // {

            // }
            items.Add(item);
            if (onChange != null)
            {
                onChange.Invoke();
            }
        }
        else 
        {
            Debug.Log("No hay espacio disponible");
        }
    }

    public void Remove(Item item) 
    {
        if (items.Contains(item))
        {
            items.Remove(item);
            if (onChange != null)
            {
                onChange.Invoke();
            }
        }
        else
        {
            Debug.Log("No existe el objeto en el inventario");
        }
    }
}
