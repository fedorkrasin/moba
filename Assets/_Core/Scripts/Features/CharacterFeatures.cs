using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

[CreateAssetMenu(menuName = "ScriptableObjects/CharacterFeatures", fileName = "CharacterFeatures")]
public class CharacterFeatures : UnitFeatures
{
    [Header("Stats")] 
    [SerializeField] private AttributeTypes _attribute;
    [Space]
    [SerializeField] private float _baseStrength;
    [SerializeField] private float _baseAgility;
    [SerializeField] private float _baseIntelligence;

    [Header("Stats Gain")]
    [SerializeField] private float _strengthGain;
    [SerializeField] private float _agilityGain;
    [SerializeField] private float _intelligenceGain;
    
    public override int Health => FeaturesCalculator.CalculateHealth(base.Health, (int) Strength);
    public override int Mana => FeaturesCalculator.CalculateMana(base.Mana, (int) Intelligence);
    
    public override int Damage => FeaturesCalculator.CalculateDamage(base.Damage, baseAttributeStats);
    
    public float Strength => FeaturesCalculator.CalculateStrength(_baseStrength, _strengthGain, CurrentLevel);
    public float Agility => FeaturesCalculator.CalculateAgility(_baseAgility, _agilityGain, CurrentLevel);
    public float Intelligence => FeaturesCalculator.CalculateIntelligence(_baseIntelligence, _intelligenceGain, CurrentLevel);
    
    private int baseAttributeStats => _attribute switch
    {
        AttributeTypes.Strength =>  (int) Strength,
        AttributeTypes.Agility => (int) Agility,
        AttributeTypes.Intelligence => (int) Intelligence,
        _ => 0
    };
}
