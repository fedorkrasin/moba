using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : IRegenerable
{
    private int _maxHealth;
    private int _currentHealth;

    private float _currentExactHealth;

    public HealthSystem(int health)
    {
        _maxHealth = health;
        _currentHealth = health;
    }

    public float GetHealth() => _currentHealth;

    public void Damage(int damageAmount)
    {
        _currentHealth -= damageAmount;

        if (_currentHealth < 0) _currentHealth = 0;
    }

    public void Heal(int healAmount)
    {
        _currentHealth += healAmount;

        if (_currentHealth > _maxHealth) _currentHealth = _maxHealth;
    }

    public void Regenerate(float regeneration)
    {
        if (_currentHealth != (int) _currentExactHealth) _currentExactHealth = _currentHealth;
        
        if (_currentExactHealth <= _maxHealth)
        {
            _currentExactHealth += regeneration;
            _currentHealth = (int) _currentExactHealth;
        }
        else
        {
            _currentExactHealth = _maxHealth;
            _currentHealth = _maxHealth;
        }
    }

    public void Update(int newHealth)
    {
        var healthRatio = _currentExactHealth / _maxHealth;
        _maxHealth = newHealth;
        _currentExactHealth = healthRatio * _maxHealth;
        _currentHealth = (int) _currentExactHealth;
    }
}
