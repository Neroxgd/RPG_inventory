using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmorScript : MonoBehaviour, IEquipable
{
    public Image _image;
    public Sprite _ArmorSprite;
    public void Equipable()
    {
        Debug.Log("Equip");
        _image.sprite = _ArmorSprite; 
    }
}
