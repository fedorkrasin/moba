using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    [SerializeField] private UnitFeatures _features;

    public UnitFeatures Features => _features;
    
    protected HealthSystem _health;
    protected ManaSystem _mana;
    protected LevelSystem _level;

    private void Start()
    {
        _health = new HealthSystem(_features.Health);
        _mana = new ManaSystem(_features.Mana);
        _level = new LevelSystem(_features.CurrentLevel);
    }
}
