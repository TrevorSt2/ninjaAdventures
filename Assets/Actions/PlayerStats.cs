using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats", menuName = "PlayerStats/Create new PlayerStats")]
public class PlayerStats : ScriptableObject
{
    public int CurrentLevel;
    public float CurrentHealth;
    public float MaxHealth;
    public float CurrentMana;
    public float MaxMana;

    public void ResetPlayer()
    {
        CurrentHealth = 10;
        CurrentMana = 10;
    }

    public void RevivePlayer()
    {
        CurrentHealth = MaxHealth/2;
        CurrentMana = MaxMana/2;
    }
}
