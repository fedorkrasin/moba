using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/FeaturesCalculatorSettings", fileName = "FeaturesCalculatorSettings")]
public class FeaturesCalculatorSettings : ScriptableObject
{
    [SerializeField] private int _hpForStrength;
    [SerializeField] private int _mpForIntelligence;

    public int HpForStrength => _hpForStrength;
    public int MpForIntelligence => _mpForIntelligence;
}
