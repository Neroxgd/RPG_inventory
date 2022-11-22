using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item/Armor", fileName = "Armor")]
public class Armor : Item, IEquipable, IDRopable
{

    public Inventory inventory ; 

    public ItemInstance _itemInstances;

    public bool Equipable()
    {
        throw new System.NotImplementedException();
    }

    public void Drop()
    {
        _itemInstances._quantity = _itemInstances._quantity - 1;
    }
}
