using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Character : Unit
{
    private void OnMouseDown()
    {
        Debug.Log("HP: " + _health.GetHealth());
        Debug.Log("MP: " + _mana.GetMana());
        Debug.Log("Level: " + _level.GetCurrentLevel());
    }
}
