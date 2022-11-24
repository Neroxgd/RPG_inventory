using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{       
    public UiInventory _UiInventory;

    public Transform _PlayerTransform;

    public Inventory _inventory;
    public void DropItem()
    {
        Vector3 _InstantiateDrop = new Vector3 (_PlayerTransform.position.x, _PlayerTransform.position.y, _PlayerTransform.position.z - 2);

        _inventory._itemInstances[_UiInventory._IdIndex]._quantity -= 1 ;
        
        Instantiate(_inventory._itemInstances[_UiInventory._IdIndex]._item._PhysicalRepresentation, _InstantiateDrop, Quaternion.identity);

        if(_inventory._itemInstances[_UiInventory._IdIndex]._quantity == 0)
        {
            _inventory._itemInstances.Remove(_inventory._itemInstances[_UiInventory._IdIndex]);
        }
    }
}
