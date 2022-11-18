using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TheKiwiCoder;

[System.Serializable]
public class IAMove : ActionNode
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
        iABlackBoard._move.SetMove(Vector2.left * 10);
        Debug.Log("zzzz");
        return State.Success;
    }
}
