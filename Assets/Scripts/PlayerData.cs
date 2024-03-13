using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    [SerializeField] PlayerStats playerStats;

    PlayerAnimations playerAnimations;

    public PlayerStats PlayerStats => playerStats;

    private void Awake()
    {
        playerAnimations = GetComponent<PlayerAnimations>();
    }

    public void playerRevive()
    {

        PlayerStats.RevivePlayer();
        playerAnimations.ResetPlayerAnimation();
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Return))
        {
            playerRevive();
        }
    }
}
