using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item/Weapon", fileName = "Weapon")]
public class Weapon : Item, IEquipable
{

    public Inventory inventory ; 

    public ItemInstance _itemInstances;
    
    public bool Equipable()
    {
        throw new System.NotImplementedException();
    }
}
