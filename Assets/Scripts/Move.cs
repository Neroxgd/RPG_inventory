using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    [SerializeField] private Rigidbody _rbPlayer;
    private Vector2 moveVal = Vector2.zero;
    public float moveSpeed;

    public void OnMove(InputValue value)
    {
        moveVal = value.Get<Vector2>();
    }
    void FixedUpdate()
    {
        _rbPlayer.velocity = (new Vector3(moveVal.x, _rbPlayer.velocity.y/9.5f, moveVal.y) * moveSpeed);
    }
}

