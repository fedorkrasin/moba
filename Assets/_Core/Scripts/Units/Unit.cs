using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    [SerializeField] private UnitFeatures _features;
    
    protected HealthSystem _health;

    private void Start()
    {
        _health = new HealthSystem(_features.BaseHealth);
    }
}
