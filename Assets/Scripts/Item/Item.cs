using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : ScriptableObject
{
    public string _name = "default";

    public GameObject _PhysicalRepresentation;

    public Sprite _InventoryRepresentation;
}
