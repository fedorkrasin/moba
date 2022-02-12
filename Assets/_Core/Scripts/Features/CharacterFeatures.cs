using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

[CreateAssetMenu(menuName = "ScriptableObjects/CharacterFeatures", fileName = "CharacterFeatures")]
public class CharacterFeatures : UnitFeatures
{
    [Inject] private FeaturesCalculator _calculator;
    
    [SerializeField] private float _strength;
    
    public override int Health => _calculator.CalculateHealth(_baseHealth, (int) _strength);
    public float Strength => _strength;
}
