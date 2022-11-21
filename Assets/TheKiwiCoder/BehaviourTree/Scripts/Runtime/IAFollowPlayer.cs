using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TheKiwiCoder;
using UnityEngine.AI;

[System.Serializable]
public class IAFollowPlayer : ActionNode
{
    [SerializeField] private Move _move;
    
    protected override void OnStart() {
    }

    protected override void OnStop() {
    }

    protected override State OnUpdate() {
        IABlackBoard iABlackBoard = blackboard as IABlackBoard;

        if (iABlackBoard == null)
        {
            return State.Failure; 
        }
        Ray ray = new Ray(iABlackBoard._player.transform.position, -iABlackBoard._player.transform.up);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
            iABlackBoard._agent.GetComponent<NavMeshAgent>().SetDestination(hit.point);
        Debug.Log("fffffffffuuuck");
        return State.Success;
    }
}
