using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR.Haptics;

public enum EnemyState
{
    NONE, WANDER, PATROL, CHASE, ATTACK
}

public class EnemyBrain : MonoBehaviour
{
    [SerializeField] EnemyState stateID;
    [SerializeField] FSM_State[] states;

    public FSM_State CurrentState { get; private set; }

    public Transform Player { get; set; }

    FSM_State GetState(EnemyState newStateID)
    {
        for (int i = 0; i < states.Length; i++)
        {
            if (states[i].ID == newStateID)
            {
                return states[i];
            }
        }

        return null;
    }

    public void ChangeState(EnemyState newState)
    {
        FSM_State state = GetState(newState);
        if(state == null)
        {
            return;
        }

        CurrentState = state;
    }


    private void Update()
    {
        if (CurrentState == null)
        {
            return;
        }

        CurrentState.UpdateState(this);
    }

    private void Start()
    {
        ChangeState(stateID);
    }
}



