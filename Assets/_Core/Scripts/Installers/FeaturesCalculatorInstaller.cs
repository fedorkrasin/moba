using UnityEngine;
using Zenject;

public class FeaturesCalculatorInstaller : MonoInstaller
{
    [SerializeField] private FeaturesCalculatorSettings _settings;
    
    public override void InstallBindings()
    {
        Container.Bind<FeaturesCalculator>()
            .FromNew()
            .AsSingle()
            .WithArguments(_settings);
    }
}