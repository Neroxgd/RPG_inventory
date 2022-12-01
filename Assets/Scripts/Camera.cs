using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Rigidbody rb_cam;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb_cam.MovePosition(target.position);
    }
}
