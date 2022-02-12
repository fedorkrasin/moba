using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UnitFeatures : ScriptableObject
{
    [SerializeField] protected int _baseHealth;

    public virtual int Health => _baseHealth;
}
