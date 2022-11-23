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

        if (iABlackBoard.posagent.position == iABlackBoard.randompos || !iABlackBoard._agent.hasPath)
        {
            //NE MARCHE PAS CAR ILS NE SONT PAS A LA MEME POSITION EXACTEMENT (l'ia et la random pos)
            RandomPos();
            compteur += Time.deltaTime;
            if (compteur > 5)
            {
                agentGoToPos();
                compteur = 0;

            }

        }

        Debug.Log(iABlackBoard.posagent.position);
        Debug.Log(iABlackBoard.randompos);
        Debug.Log(!iABlackBoard._agent.hasPath);
        return State.Success;

    }

    public void agentGoToPos()
    {
        iABlackBoard._agent.SetDestination(iABlackBoard.randompos);
    }

    public void RandomPos()
    {
        iABlackBoard.randompos = new Vector3(Random.Range(iABlackBoard.minRandomPosX, iABlackBoard.maxRandomPosX), iABlackBoard.posagent.position.y, Random.Range(iABlackBoard.minRandomPosY, iABlackBoard.maxRandomPosY));
    }
}
