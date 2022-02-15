using GameLearnProject.Input;
using GameLearnProject.LoaderScripts.Interfaces;
using GameLearnProject.LoaderScripts.Parsers;
using GameLearnProject.LoaderScripts.Parsers.HelperParser;
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
            
            Container.Bind<ISaverSerializeData>().To<FileSaverSerializeData>().FromNew().AsSingle().NonLazy();
            Container.Bind<IParser>().To<JsonParser>().FromNew().AsSingle().NonLazy();
        }
    }
}