using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item/Armor", fileName = "Armor")]
public class Armor : Item, IEquipable
{

    public Inventory inventory ; 

    public ItemInstance _itemInstances;

    public bool Equipable()
    {
        throw new System.NotImplementedException();
    }

}
