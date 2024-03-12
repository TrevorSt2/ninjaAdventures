using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class PlayerMana : MonoBehaviour
{
    PlayerData playerData;

    private void Awake()
    {
        playerData = GetComponent<PlayerData>();
    }

    public void UseMana(float amount)
    {
        if (playerData.PlayerStats.CurrentMana >= amount)
        {
            playerData.PlayerStats.CurrentMana -= amount;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) {
            UseMana(5f);
        }
    }
}
