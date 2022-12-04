using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseScript : MonoBehaviour, IConsommable
{

    [SerializeField] Life   _life;

    [SerializeField] UiInventory _UiInventory;

    [SerializeField] Inventory _inventory;
    public void Consume()
    {
        _life = GameObject.Find("PlayerHuman").GetComponent<Life>();
        _inventory = GameObject.Find("PlayerHuman").GetComponent<Inventory>();
        _UiInventory = GameObject.Find("Canvas_Inventory").transform.GetChild(0).GetChild(0).GetComponent<UiInventory>();
        
        if (_life.life < _life.MaxLife)
        {
            _life.life = 150 ;
            _inventory._itemInstances[_UiInventory._IdIndex]._quantity -= 1 ;
        }


    }
}
