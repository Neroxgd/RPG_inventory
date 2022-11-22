using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item/Potion", fileName = "Potion")]
public class Potion : Item, IConsommable, IDRopable
{
    public Inventory inventory ; 

    public ItemInstance _itemInstances;
    public bool Consume()
    {
        throw new System.NotImplementedException();
    }

    public void Drop()
    {
        _itemInstances._quantity = _itemInstances._quantity - 1;
    }
}