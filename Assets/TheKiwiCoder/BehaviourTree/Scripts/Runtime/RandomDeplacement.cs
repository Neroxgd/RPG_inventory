using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TheKiwiCoder;

[System.Serializable]
public class RandomDeplacement : ActionNode
{
    IABlackBoard iABlackBoard;
    private float compteur = 0;
    protected override void OnStart()
    {
    }

    protected override void OnStop()
    {
    }

    protected override State OnUpdate()
    {
        iABlackBoard = blackboard as IABlackBoard;
        if (iABlackBoard == null)
        {
            return State.Failure;
        }


        if (!iABlackBoard._iASensor.ifdetected)
        {   
            if (!iABlackBoard._agent.hasPath || Vector3.Distance(iABlackBoard._agent.transform.position, iABlackBoard._agent.steeringTarget) < 1.5f)
                compteur += Time.deltaTime;
            if (compteur > 5)
            {
                iABlackBoard._agent.ResetPath();
                RandomPos();
                agentGoToPos();
                compteur = 0;
            }
            return State.Success;
        }

        return State.Failure;
    }

    public void agentGoToPos()
    {
        iABlackBoard._agent.SetDestination(iABlackBoard.randompos);
    }

    public void RandomPos()
    {
        iABlackBoard.randompos = new Vector3(Random.Range(iABlackBoard.minRandomPosX, iABlackBoard.maxRandomPosX), iABlackBoard.posagent.position.y, Random.Range(iABlackBoard.minRandomPosZ, iABlackBoard.maxRandomPosZ));
    }
}
