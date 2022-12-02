using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IAAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private IASensor _iASensor;

    void Update()
    {
        if (GetComponent<NavMeshAgent>().hasPath && Vector3.Distance(transform.position, GetComponent<NavMeshAgent>().steeringTarget) > 2) 
            _animator.SetBool("Run", true);
        else 
            _animator.SetBool("Run", false);
    }
}
