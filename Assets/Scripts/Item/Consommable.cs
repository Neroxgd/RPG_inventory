using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Consommable", menuName = "Item/Consommable")]
public class Consommable : Item 
{

}

public interface IUsable
{
    public bool use();
}