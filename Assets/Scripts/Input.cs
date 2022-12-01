using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Input : MonoBehaviour
{
    private Vector2 moveVal = Vector2.zero;
    [SerializeField] Move _move;
    public void OnMove(InputValue value)
    {
        //get input values (ZQSD/arrows) to move
        moveVal = value.Get<Vector2>();
        _move.SetMove(moveVal);
    }
}
