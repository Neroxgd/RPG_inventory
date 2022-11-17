using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item/Armor", fileName = "Armor")]
public class Armor : Item, IEquipable, IDRopable
{
    public bool Equipable()
    {
        throw new System.NotImplementedException();
    }

    public bool Drop()
    {
        throw new System.NotImplementedException();
    }
}
