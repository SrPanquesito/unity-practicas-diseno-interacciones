using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New Food", menuName="Inventory/Consumable")]

public class Food : Item
{
    public float lifeAmount = 5.0f;
    public float hunger = 1.0f;

    public override void Use()
    {
        base.Use();
        Debug.Log($"Aumento barra de comida en {hunger} unidades");
    }
}
