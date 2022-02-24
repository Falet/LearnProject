using Cysharp.Threading.Tasks;
using GameLearnProject.ItemsComponents.Interfaces;
using GameLearnProject.LoaderScripts;
using GameLearnProject.LoaderScripts.Interfaces;
using GameLearnProject.PawnComponents;
using GameLearnProject.PawnComponents.Interfaces;
using GameLearnProject.PlayerScripts;
using GameLearnProject.PlayerScripts.TypeView;
using GameLearnProject.ReferenceTypeForSerializedData;
using GameLearnProject.ReferenceTypeForSerializedData.ItemsData;
using UnityEngine;
using Zenject;

namespace GameLearnProject.ZenjectScripts.GameObjectInstallers
{
    public enum TypeTransform
    {
        TransformForTypeView
    }
    
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField] private GameObject _containerOfScripts;
        [SerializeField] private GameObject _playerTrasnform;
        [SerializeField] private GameObject _prefabContainer;
        [SerializeField] private GameObject _prefabTypeView;

        [SerializeField] private GameObject _prefabWeapon;
        [SerializeField] private ItemData _itemData;
        
        public override void InstallBindings()
        {
            Container.Bind<Transform>().WithId(TypeTransform.TransformForTypeView).FromComponentOn(_playerTrasnform)
                .AsSingle().NonLazy();

            Container.Bind<TypeViewController>().FromSubContainerResolve().ByNewContextPrefab(_prefabTypeView)
                .UnderTransform(_playerTrasnform.transform).AsSingle().NonLazy();

            Container.Bind<IAttack>().To<AttackController>().FromComponentOn(_containerOfScripts).AsSingle().NonLazy();

            Container.BindIFactory<ItemData, UniTask<IItem>>().FromFactory<LoaderItems.FactoryItems>().NonLazy();
            //Container.Bind<ILoader>().To<LoaderItems>().FromComponentOn(_containerOfScripts).AsSingle().NonLazy();

            //Container.BindFactory<ItemSerializedData, IWeapon, WeaponInstaller.Factory>().FromFactory<WeaponInstaller.Factory>();

            Container.Bind<Inventory>().FromComponentOn(_containerOfScripts).AsSingle().NonLazy();
            Container.Bind<Player>().FromComponentOn(_containerOfScripts).AsSingle().NonLazy();
        }
    }
}