using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeaturesCalculator
{
    private FeaturesCalculatorSettings _settings;

    public FeaturesCalculator(FeaturesCalculatorSettings settings)
    {
        _settings = settings;
    }

    public int CalculateHealth(int baseHealth, int strength)
    {
        return baseHealth + strength * _settings.HpForStrength;
    }
}
