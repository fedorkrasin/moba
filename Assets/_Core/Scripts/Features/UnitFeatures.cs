using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UnitFeatures : ScriptableObject
{
    [SerializeField] private int _baseHealth;
    [SerializeField] private int _baseMana;

    [SerializeField] private float _baseHealthRegeneration;
    [SerializeField] private float _baseManaRegeneration;

    [SerializeField] private int _minDamage;
    [SerializeField] private int _maxDamage;
    
    [SerializeField] private int _currentLevel;
    [SerializeField] private int _maxLevel;
    
    public virtual int Health => _baseHealth;
    public virtual int Mana => _baseMana;

    public virtual float HealthRegeneration => _baseHealthRegeneration;
    public virtual float ManaRegeneration => _baseManaRegeneration;

    public virtual int Damage => Random.Range(_minDamage, _maxDamage + 1);
    public virtual int MediumDamage => (_minDamage + _maxDamage) / 2;

    public int CurrentLevel => _currentLevel;
    public int MaxLevel => _maxLevel;

    public void SetCurrentLevel(int level) => _currentLevel = level;
}
