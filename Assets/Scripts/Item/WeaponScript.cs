using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponScript : MonoBehaviour, IEquipable
{
    public Sprite _WeaponSprite;
    [SerializeField] UiInventory _UiInventory;

    [SerializeField] Inventory _inventory;

    [SerializeField] Attack _attack;
    public void Equipable()
    {
        Image _image = GameObject.Find("Canvas_Inventory").transform.GetChild(0).GetChild(4).GetChild(1).GetComponent<Image>();
        GameObject _weapon = GameObject.Find("PlayerHuman").transform.GetChild(0).GetChild(0).GetChild(2).GetChild(0).GetChild(0).GetChild(2).GetChild(0).GetChild(0).GetChild(0).GetChild(1).GetChild(0).gameObject;
        _inventory = GameObject.Find("PlayerHuman").GetComponent<Inventory>();
        _UiInventory = GameObject.Find("Canvas_Inventory").transform.GetChild(0).GetChild(0).GetComponent<UiInventory>();
        _attack = GameObject.Find("PlayerHuman").transform.GetChild(3).GetComponent<Attack>();
        _attack.dmg += 10;
        _weapon.SetActive(true);
        _image.sprite = _WeaponSprite;
        _inventory._itemInstances[_UiInventory._IdIndex]._quantity -= 1;
    }
}
