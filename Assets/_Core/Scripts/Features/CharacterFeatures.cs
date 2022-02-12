using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/CharacterFeatures", fileName = "CharacterFeatures")]
public class CharacterFeatures : UnitFeatures
{
    [SerializeField] private float _strength;

    public float Strength => _strength;
}
