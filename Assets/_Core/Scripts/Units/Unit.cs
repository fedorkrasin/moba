using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    [SerializeField] private UnitFeatures _features;

    public UnitFeatures Features => _features;
    
    public HealthSystem Health { get; set; }
    public ManaSystem Mana { get; set; }
    public LevelSystem Level { get; set; }

    private void Start()
    {
        Health = new HealthSystem(_features.Health);
        Mana = new ManaSystem(_features.Mana);
        Level = new LevelSystem(_features.CurrentLevel);
    }
}
