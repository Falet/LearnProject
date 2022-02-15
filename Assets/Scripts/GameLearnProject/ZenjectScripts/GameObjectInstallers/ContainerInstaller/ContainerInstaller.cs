using GameLearnProject.ItemsComponents.Interfaces;
using GameLearnProject.ItemsComponents.ItemContainer.Interfaces;
using GameLearnProject.LoaderScripts;
using GameLearnProject.LoaderScripts.Interfaces;
using GameLearnProject.PawnComponents;
using UnityEngine;
using Zenject;

namespace GameLearnProject.ZenjectScripts.GameObjectInstallers.ContainerInstaller
{
    public class ContainerInstaller : MonoInstaller
    {
        [SerializeField] private GameObject _containerOfScripts;
        
        public override void InstallBindings()
        {
            Container.Bind<IContainer>().FromInstance(_containerOfScripts.GetComponent<IContainer>()).AsSingle()
                .NonLazy();

            Container.BindIFactory<Object, IItem>().FromFactory<Loader.FactoryItems>().NonLazy();
            Container.Bind<ILoader>().To<Loader>().FromComponentOn(_containerOfScripts).AsSingle().NonLazy();

            Container.Bind<Inventory>().FromComponentOn(_containerOfScripts).AsSingle().NonLazy();
        }
    }
}