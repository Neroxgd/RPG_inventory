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
<<<<<<< HEAD
        //move in the direction, apply the gravity
        _rbPlayer.velocity = new Vector3(moveVal.x, -Mathf.Abs(_rbPlayer.velocity.y / gravityPower), moveVal.y) * moveSpeed;
        
        //look the good rotation
        SetRotation();
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, currentRotation, 0), 0.5f);
        Debug.Log(Physics.gravity);
    }

    void LateUpdate()
    {

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
=======
        _rbPlayer.velocity = (new Vector3(moveVal.x, _rbPlayer.velocity.y/9.5f, moveVal.y) * moveSpeed);
>>>>>>> parent of 5d3a076 (grgr)
    }
}

