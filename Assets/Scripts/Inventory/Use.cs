using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Use : MonoBehaviour
{
    public Inventory _inventory;

    public UiInventory _UiInventory;

    public void EquipItem()
    {
        if (_inventory._itemInstances[_UiInventory._IdIndex]._item is IConsommable)
        {
            IConsommable _newitem =  _inventory._itemInstances[_UiInventory._IdIndex]._item._PhysicalRepresentation.GetComponent<IConsommable>();
            _newitem.Consume();
        }
        else
        {
            Debug.Log("False");
        }
    }
}
