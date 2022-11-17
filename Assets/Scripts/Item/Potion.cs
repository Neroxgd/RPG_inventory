using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item/Potion", fileName = "Potion")]
public class Potion : Item, IConsommable, IDRopable
{
    public bool Consume()
    {
        throw new System.NotImplementedException();
    }

    public bool Drop()
    {
        throw new System.NotImplementedException();
    }
}
