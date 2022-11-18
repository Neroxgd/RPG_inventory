using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TheKiwiCoder;
using UnityEngine.AI;

namespace TheKiwiCoder
{
    public class IABlackBoard : Blackboard
    {
        public Move _move;
        public GameObject _player;
        public NavMeshAgent _agent;
    }
}