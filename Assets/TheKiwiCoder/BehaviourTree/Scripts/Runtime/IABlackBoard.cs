using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TheKiwiCoder;
using UnityEngine.AI;

namespace TheKiwiCoder
{
    public class IABlackBoard : Blackboard
    {
        public GameObject _player;
        public NavMeshAgent _agent;
        public GameObject _IA;
        public Transform posagent;
        public Vector3 randompos;
        public float minRandomPosX;
        public float maxRandomPosX;
        public float minRandomPosZ;
        public float maxRandomPosZ;
        public IASensor _iASensor;
    }
}