using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private Rigidbody _rbPlayer;
    public float moveSpeed = 10;
    public float currentRotation = 0;
    [SerializeField] private float gravityPower = 9.4f;
    private Vector2 moveVal;
    [SerializeField] _Camera _camera;

    public void SetMove(Vector2 move)
    {
        moveVal=move;
    }

    void FixedUpdate()
    {
        _camera.Cam();
        //move in the direction, apply the gravity
        _rbPlayer.velocity = new Vector3(moveVal.x, -Mathf.Abs(_rbPlayer.velocity.y / gravityPower), moveVal.y) * moveSpeed;

        //animation
        if (moveVal != Vector2.zero)
            _animator.SetBool("Run", true);
        else _animator.SetBool("Run", false);

        //look the good rotation
        SetRotation();
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, currentRotation, 0), 0.5f);
    }

    //set the good looking rotation
    public void SetRotation()
    {
        if (moveVal == new Vector2(0, 1))
            currentRotation = 0;
        else if (moveVal == new Vector2(1, 1).normalized)
            currentRotation = 45;
        else if (moveVal == new Vector2(1, 0))
            currentRotation = 90;
        else if (moveVal == new Vector2(1, -1).normalized)
            currentRotation = 135;
        else if (moveVal == new Vector2(0, -1))
            currentRotation = 180;
        else if (moveVal == new Vector2(-1, -1).normalized)
            currentRotation = 225;
        else if (moveVal == new Vector2(-1, 0))
            currentRotation = 270;
        else if (moveVal == new Vector2(-1, 1).normalized)
            currentRotation = 315;
    }
}

