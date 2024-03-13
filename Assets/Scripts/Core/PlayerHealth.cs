using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlayerHealth : MonoBehaviour, IDamageable 
{
    [SerializeField] PlayerStats playerStats;
    PlayerAnimations animations;

    private void Awake()
    {
        animations = GetComponent<PlayerAnimations>();

    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(1f);
        }

    }
    public void TakeDamage(float damage)
    {
        playerStats.CurrentHealth -= damage;

        if (playerStats.CurrentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        animations.handleDeadAnimation();
    }
}
