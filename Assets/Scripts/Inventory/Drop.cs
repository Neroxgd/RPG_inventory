using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{       
    public UiInventory _UiInventory;

    public Inventory _inventory;
    public void DropItem()
    {
        int ItemQuantity = _inventory._itemInstances[_UiInventory._IdIndex]._quantity ;
        ItemQuantity = ItemQuantity - 1 ;

    }
}
