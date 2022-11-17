using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.AI;

public class IA : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private NavMeshAgent _agent;
    void Update()
    {
        Ray ray = new Ray(_player.transform.position, -_player.transform.up);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
            _agent.SetDestination(hit.point);
    }
}