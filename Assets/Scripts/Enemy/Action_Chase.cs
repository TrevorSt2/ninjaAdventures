using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Action_Chase : FSM_Action
{
    [SerializeField] float chaseSpeed;
    [SerializeField] float stoppingDistance;

    EnemyBrain enemyBrain;

    public override void Act()
    {
        throw new System.NotImplementedException();
    }

    private void Awake()
    {
        enemyBrain = GetComponent<EnemyBrain>();
    }

    void ChasePlayer()
    {
        if (enemyBrain.Player == null)
            return;

        Vector3 direction = enemyBrain.Player.position - transform.position;

        if (direction.magnitude >= stoppingDistance)
            transform.Translate(direction.normalized * (chaseSpeed * Time.deltaTime));
    }
}
