using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/FeaturesCalculatorSettings", fileName = "FeaturesCalculatorSettings")]
public class FeaturesCalculatorSettings : ScriptableObject
{
    [SerializeField] private int _hpForStrength;
    [SerializeField] private int _mpForIntelligence;

    [SerializeField] private float _hpRegenForStrength;
    [SerializeField] private float _mpRegenForIntelligence;

    public int HpForStrength => _hpForStrength;
    public int MpForIntelligence => _mpForIntelligence;

    public float HpRegenForStrength => _hpRegenForStrength;
    public float MpRegenForIntelligence => _mpRegenForIntelligence;
}
