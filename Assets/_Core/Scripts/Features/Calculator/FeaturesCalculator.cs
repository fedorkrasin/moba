using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeaturesCalculator : Singleton<FeaturesCalculator>
{
    [SerializeField] private FeaturesCalculatorSettings _settings;

    public static int CalculateHealth(int baseHealth, int strength)
    {
        return baseHealth + strength * Instance._settings.HpForStrength;
    }

    public static int CalculateMana(int baseMana, int intelligence)
    {
        return baseMana + intelligence * Instance._settings.MpForIntelligence;
    }

    public static float CalculateHealthRegeneration(float baseHealthRegeneration, int strength)
    {
        return baseHealthRegeneration + strength * Instance._settings.HpRegenForStrength;
    }
    
    public static float CalculateManaRegeneration(float baseManaRegeneration, int intelligence)
    {
        return baseManaRegeneration + intelligence * Instance._settings.MpRegenForIntelligence;
    }

    public static int CalculateDamage(int baseDamage, int stats)
    {
        return baseDamage + stats;
    }

    public static float CalculateStrength(float baseStrength, float strengthGain, int currentLevel)
    {
        return baseStrength + strengthGain * currentLevel;
    }
    
    public static float CalculateAgility(float baseAgility, float agilityGain, int currentLevel)
    {
        return baseAgility + agilityGain * currentLevel;
    }
    
    public static float CalculateIntelligence(float baseIntelligence, float intelligenceGain, int currentLevel)
    {
        return baseIntelligence + intelligenceGain * currentLevel;
    }
}
