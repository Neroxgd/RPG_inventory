using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item/Potion", fileName = "Potion")]
public class Potion : Item, IConsommable
{
    public Inventory inventory ; 

    public ItemInstance _itemInstances;
    public bool Consume()
    {
        throw new System.NotImplementedException();
    }

}