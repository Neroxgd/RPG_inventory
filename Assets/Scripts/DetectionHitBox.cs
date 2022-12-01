using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionHitBox : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Transform empty;

    // Update is called once per frame
    void Update()
    {
        empty.position = new Vector3(Player.position.x, Player.position.y + 1.5f, Player.position.z) ;
    }
}
