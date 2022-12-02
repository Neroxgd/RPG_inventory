using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Camera : MonoBehaviour
{
    private Vector3 target;
    [SerializeField] Transform _player;
    private Vector3 velocity = Vector3.zero;

    void Update()
    {
        
    }

    public void Cam()
    {
        Debug.DrawRay(_player.position, new Vector3(0.25f, 2.5f, -5.3f));
        print(Vector3.Distance(_player.position, new Vector3(0.25f, 2.5f, -5.3f)));
        Ray ray = new Ray(_player.position, new Vector3(0.25f, 2.5f, -5.3f));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 5f))
            transform.position = Vector3.SmoothDamp(transform.position, hit.point, ref velocity, 0.1f);
        else
            transform.position = Vector3.SmoothDamp(transform.position, _player.localPosition + new Vector3(0.25f, 2.5f, -5.3f), ref velocity, 0.1f);
    }

}
