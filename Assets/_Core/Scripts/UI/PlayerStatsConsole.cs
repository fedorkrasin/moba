using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatsConsole : MonoBehaviour
{
    private const string lvl = "Level: {0}\tMax level: {1}";
    private const string hp = "HP: {0} / {1} ({2:0}%) + {3} per sec";
    private const string mp = "MP: {0} / {1} ({2:0}%) + {3} per sec";
    private const string dmg = "Damage: {0}";
    
    private const string strength = "Strength: {0} + {1}";
    private const string agility = "Agility: {0} + {1}";
    private const string intelligence = "Intelligence: {0} + {1}";
    
    [SerializeField] private Character _character;
    [SerializeField] private Text _consoleText;

    private void Start()
    {
        UpdateConsole();
    }

    private void Update()
    {
        UpdateConsole();
    }

    private void UpdateConsole()
    {
        var f = _character.Features as CharacterFeatures;

        _consoleText.text = string.Format(lvl, f.CurrentLevel, f.MaxLevel) + "\n" +
                            string.Format(hp, _character.Health.GetHealth(), f.Health, _character.Health.GetHealth() / f.Health * 100, f.HealthRegeneration) + "\n" +
                            string.Format(mp, _character.Mana.GetMana(), f.Mana, _character.Mana.GetMana() / f.Mana * 100, f.ManaRegeneration) + "\n" +
                            string.Format(dmg, f.MediumDamage) + "\n" +
                            string.Format(strength, f.Strength, f.StrengthGain) + "\n" +
                            string.Format(agility, f.Agility, f.AgilityGain) + "\n" +
                            string.Format(intelligence, f.Intelligence, f.IntelligenceGain) + "\n";
    }
}
