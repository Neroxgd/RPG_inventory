using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equip : MonoBehaviour
{
    public Inventory _inventory;

    public UiInventory _UiInventory;

    public void EquipItem()
    {
        if (_inventory._itemInstances[_UiInventory._IdIndex]._item is IEquipable)
        {
            IEquipable _newitem =  _inventory._itemInstances[_UiInventory._IdIndex]._item._PhysicalRepresentation.GetComponent<IEquipable>();
            _newitem.Equipable();
        }
        else
        {
            Debug.Log("False");
        }
    }
}
