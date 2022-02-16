using GameLearnProject.Input;
using UnityEngine;
using Zenject;

namespace GameLearnProject.ZenjectScripts.ProjectInstallers
{
    public class BootstrapInstaller : MonoInstaller
    {
        [SerializeField] private GameObject _inputObject;
        public override void InstallBindings()
        {
            Container.Bind<InputManager>().FromComponentOn(_inputObject).AsSingle().NonLazy();
        }
    }
}