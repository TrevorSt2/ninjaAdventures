using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FSM_State
{
    public EnemyState ID;
    public FSM_Action[] Actions;
    public FSM_Transition[] Transitions;


    private void ExecuteActions()
    {
        for (int i = 0; i < Actions.Length; i++)
        {
            Actions[i].Act();
        }
    }

    void ExecuteTransitions(EnemyBrain brain)
    {
        if (Transitions == null || Transitions.Length <= 0)
            return;

        for (int i = 0; i < Transitions.Length; i++)
        {
            bool value = Transitions[i].Decision.Decide();

            if (value)
            {
                //ChangeState(Transitions[i].TrueState);
            }
            else
            {
                //ChangeState(Transitions[i].FalseState);
            }
        }
    }
}

