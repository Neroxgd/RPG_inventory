using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    private Vector2 moveVal;
    public float moveSpeed;

    public void OnMove(InputValue value)
    {
        moveVal = value.Get<Vector2>();
    }
    void Update()
    {
        transform.Translate(new Vector3(moveVal.x, 0, moveVal.y) * moveSpeed * Time.deltaTime);
        Debug.Log(moveVal);
    }
}
