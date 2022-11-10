using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    [SerializeField] private Rigidbody _rbPlayer;
    private Vector2 moveVal = Vector2.zero;
    [SerializeField] private float moveSpeed;
    private float currentRotation = 0;
    private float lerpRotate = 0;
    public void OnMove(InputValue value)
    {
        moveVal = value.Get<Vector2>();
    }
    void Start()
    {
        // saveRotation = moveVal;
    }
    void FixedUpdate()
    {
        _rbPlayer.velocity = (new Vector3(moveVal.x, _rbPlayer.velocity.y / 9.6f, moveVal.y) * moveSpeed);
        SetRotation();
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, currentRotation, 0), 0.5f);
        Debug.Log(currentRotation);

    }

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

