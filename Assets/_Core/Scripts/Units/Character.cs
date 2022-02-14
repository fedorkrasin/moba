using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Character : Unit
{
    private void OnMouseDown()
    {
        Debug.Log("HP: " + Health.GetHealth());
        Debug.Log("MP: " + Mana.GetMana());
        Debug.Log("Level: " + Level.GetCurrentLevel());
    }
}
