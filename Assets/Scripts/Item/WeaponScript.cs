using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponScript : MonoBehaviour, IEquipable
{
    public Sprite _WeaponSprite;
    public void Equipable()
    {
        Image  _image = GameObject.Find("Canvas").transform.GetChild(0).GetChild(4).GetChild(1).GetComponent<Image>();
        GameObject _weapon = GameObject.Find("Capsule").transform.GetChild(1).gameObject;
        _weapon.SetActive(true);
        _image.sprite = _WeaponSprite ; 
    }
}
