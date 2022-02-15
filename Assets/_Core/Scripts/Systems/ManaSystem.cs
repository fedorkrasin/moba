using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaSystem : IRegenerable
{
    private int _maxMana;
    private int _currentMana;

    private float _currentExactMana;

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

    public void Regenerate(float regeneration)
    {
        if (_currentMana != (int) _currentExactMana) _currentExactMana = _currentMana;
        
        if (_currentExactMana <= _maxMana)
        {
            _currentExactMana += regeneration;
            _currentMana = (int) _currentExactMana;
        }
        else
        {
            _currentExactMana = _maxMana;
            _currentMana = _maxMana;
        }
    }
}
