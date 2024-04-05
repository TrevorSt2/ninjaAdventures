using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decision_DetectPlayer : FSM_Decision
{
    [SerializeField] float aggroRange;
    [SerializeField] LayerMask playerMask;

    EnemyBrain enemy;


    private void Awake()
    {
        enemy = GetComponent<EnemyBrain>(); 
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, aggroRange);
    }

    bool detectPlayer()
    {
        Collider2D playerCollider = Physics2D.OverlapCircle(transform.position, aggroRange, playerMask);
    
        if (playerCollider != null)
        {
            enemy.Player = playerCollider.transform;
            return true;
        }

        enemy.Player = null;
        return false;
    }

    public override bool Decide()
    {
        return detectPlayer();
    }

}