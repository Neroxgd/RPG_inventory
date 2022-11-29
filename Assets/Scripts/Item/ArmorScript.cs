using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmorScript : MonoBehaviour, IEquipable
{
    public Sprite _ArmorSprite;
    public void Equipable()
    {
        Image  _image = GameObject.Find("Canvas").transform.GetChild(0).GetChild(4).GetChild(2).GetComponent<Image>();
        GameObject _armor = GameObject.Find("Capsule").transform.GetChild(0).gameObject;
        _armor.SetActive(true);
        _image.sprite = _ArmorSprite ; 
    }
}
