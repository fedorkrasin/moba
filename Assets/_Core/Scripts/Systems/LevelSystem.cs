using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSystem
{
    private int _currentLevel;
    private int _maxLevel;

    public LevelSystem(int currentLevel)
    {
        _currentLevel = currentLevel;
        _maxLevel = currentLevel;
    }

    public LevelSystem(int currentLevel, int maxLevel)
    {
        _currentLevel = currentLevel;
        _maxLevel = maxLevel;
    }

    public int GetCurrentLevel() => _currentLevel;

    public void LevelUp()
    {
        if (_currentLevel < _maxLevel) _currentLevel++;
    }

    public void SetCurrentLevel(int level)
    {
        if (level <= _maxLevel) _currentLevel = level;
    }
}
