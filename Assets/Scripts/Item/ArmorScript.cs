using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmorScript : MonoBehaviour, IEquipable
{
    public Sprite _ArmorSprite;

    [SerializeField] Life _life;
    [SerializeField] UiInventory _UiInventory;

    [SerializeField] Inventory _inventory;
    public void Equipable()
    {
        Image _image = GameObject.Find("Canvas_Inventory").transform.GetChild(0).GetChild(4).GetChild(2).GetComponent<Image>();
        GameObject _armor = GameObject.Find("PlayerHuman").transform.GetChild(2).GetChild(1).gameObject;
        GameObject _basearmor = GameObject.Find("PlayerHuman").transform.GetChild(2).GetChild(0).gameObject;
        _inventory = GameObject.Find("PlayerHuman").GetComponent<Inventory>();
        _UiInventory = GameObject.Find("Canvas_Inventory").transform.GetChild(0).GetChild(0).GetComponent<UiInventory>();
        _life = GameObject.Find("PlayerHuman").GetComponent<Life>();
        _life.life += 50;

        _armor.SetActive(true);
        _basearmor.SetActive(false);
        _image.sprite = _ArmorSprite;
        _inventory._itemInstances[_UiInventory._IdIndex]._quantity -= 1;
    }
}
