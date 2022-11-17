using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item/Weapon", fileName = "Weapon")]
public class Weapon : Item, IEquipable, IDRopable
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
