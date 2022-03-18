using Cysharp.Threading.Tasks;
using GameLearnProject.ItemsComponents.Interfaces;
using GameLearnProject.ItemsComponents.ItemContainer.Interfaces;
using GameLearnProject.LoaderScripts;
using GameLearnProject.LoaderScripts.Interfaces;
using GameLearnProject.PawnComponents;
using GameLearnProject.ReferenceTypeForSerializedData.ItemsData;
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

            Container.BindIFactory<ItemData, UniTask<IItem>>().FromFactory<LoaderItems.FactoryItems<IItem, ItemData>>().NonLazy();
            Container.Bind<ILoader>().To<LoaderItems>().FromComponentOn(_containerOfScripts).AsSingle().NonLazy();

            Container.Bind<Inventory>().FromComponentOn(_containerOfScripts).AsSingle().NonLazy();
        }
    }
}