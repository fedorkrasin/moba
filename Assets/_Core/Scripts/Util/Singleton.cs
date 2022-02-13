using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Component
{
    protected static T Instance;
    
    [SerializeField] private bool _dontDestroyOnLoad;

    protected virtual void Awake()
    {
        InitializeSingleton();
        SetDontDestroyOnLoad();
    }

    private void InitializeSingleton()
    {
        if (Instance == null)
        {
            Instance = this as T;
        }
        else if (Instance == this)
        {
            Destroy(gameObject);
        }
    }

    private void SetDontDestroyOnLoad()
    {
        if (_dontDestroyOnLoad)
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}