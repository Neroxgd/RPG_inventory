using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Camera : MonoBehaviour
{
    [SerializeField] Transform _player;
    private Vector3 velocity = Vector3.zero;

    public void Cam()
    {
        Debug.DrawRay(new Vector3(_player.position.x, _player.position.y+1, _player.position.z), new Vector3(0.25f, 2.5f, -5.3f));
        Ray ray = new Ray(new Vector3(_player.position.x, _player.position.y+1, _player.position.z), new Vector3(0.25f, 2.5f, -5.3f));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 5f))
            transform.position = Vector3.SmoothDamp(transform.position, hit.point, ref velocity, 0.1f);
        else
            transform.position = Vector3.SmoothDamp(transform.position, _player.localPosition + new Vector3(0.25f, 2.5f, -5.3f), ref velocity, 0.1f);
    }
}
