using GameLearnProject.PlayerScripts.TypeView;
using GameLearnProject.PlayerScripts.TypeView.Interfaces;
using UnityEngine;
using Zenject;

namespace GameLearnProject.ZenjectScripts.GameObjectInstallers.TypeView
{
    public class TypeViewInstaller : MonoInstaller
    {
        [SerializeField] private GameObject _mainCamera;
        [SerializeField] private GameObject _containerOfScripts;
        
        public override void InstallBindings()
        {
            Container.Bind<TypeViewController>().FromComponentOn(_containerOfScripts).AsSingle().NonLazy();
            
            Container.Bind<Camera>().FromComponentOn(_mainCamera).AsSingle().NonLazy();

            Container.Bind<IMovementPawnCamera>().FromInstance(_containerOfScripts.GetComponent<IMovementPawnCamera>()).
                AsSingle().NonLazy();
            Container.Bind<IMovementPawnObject>().FromInstance(_containerOfScripts.GetComponent<IMovementPawnObject>()).
                AsSingle().NonLazy();
            Container.Bind<IRotationPawnCamera>().FromInstance(_containerOfScripts.GetComponent<IRotationPawnCamera>()).
                AsSingle().NonLazy();
            Container.Bind<IRotatePawnObject>().FromInstance(_containerOfScripts.GetComponent<IRotatePawnObject>()).
                AsSingle().NonLazy();
        }
    }
}