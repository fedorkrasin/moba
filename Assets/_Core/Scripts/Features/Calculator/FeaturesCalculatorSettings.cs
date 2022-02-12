using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/FeaturesCalculatorSettings", fileName = "FeaturesCalculatorSettings")]
public class FeaturesCalculatorSettings : ScriptableObject
{
    [SerializeField] private int _hpForStrength;

    public int HpForStrength => _hpForStrength;
}
