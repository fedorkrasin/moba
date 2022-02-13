using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaSystem
{
    private int _maxMana;
    private int _currentMana;

    public ManaSystem(int mana)
    {
        _maxMana = mana;
        _currentMana = mana;
    }

    public float GetMana() => _currentMana;
    
    public void Receive(int mana)
    {
        _currentMana += mana;

        if (_currentMana > _maxMana) _currentMana = _maxMana;
    }

    public void Spend(int mana)
    {
        _currentMana -= mana;

        if (_currentMana < 0) _currentMana = 0;
    }
}
