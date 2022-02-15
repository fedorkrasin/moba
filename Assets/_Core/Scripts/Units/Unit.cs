using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    [SerializeField] private UnitFeatures _features;

    public UnitFeatures Features => _features;
    
    public HealthSystem Health { get; private set; }
    public ManaSystem Mana { get; private set; }
    public LevelSystem Level { get; private set; }

    private void Start()
    {
        Health = new HealthSystem(_features.Health);
        Mana = new ManaSystem(_features.Mana);
        Level = new LevelSystem(_features.CurrentLevel, _features.MaxLevel);
    }

    private void Update()
    {
        RegenerateHealth();
        RegenerateMana();
        
        if (Input.GetKeyDown(KeyCode.G)) Health.Damage(50);
        if (Input.GetKeyDown(KeyCode.W)) LevelUp();
    }

    private void RegenerateHealth()
    {
        Health.Regenerate(Features.HealthRegeneration * Time.deltaTime);
    }

    private void RegenerateMana()
    {
        Mana.Regenerate(Features.ManaRegeneration * Time.deltaTime);
    }

    private void LevelUp()
    {
        UpdateHealth();
        UpdateLevel();
    }

    private void UpdateHealth()
    {
        Health.Update(Features.Health);
    }

    private void UpdateMana()
    {
        
    }

    private void UpdateLevel()
    {
        Level.LevelUp();
        _features.SetCurrentLevel(Level.GetCurrentLevel());
    }
}
