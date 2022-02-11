using GameLearnProject.ItemsComponents.Interfaces;
using GameLearnProject.PawnComponents;
using GameLearnProject.PawnComponents.Interfaces;
using GameLearnProject.PlayerScripts;
using GameLearnProject.PlayerScripts.TypeView;
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
        [SerializeField] private GameObject _prefabWeapon;
        [SerializeField] private GameObject _playerTrasnform;
        [SerializeField] private GameObject _prefabTypeView;
        
        public override void InstallBindings()
        {
            Container.Bind<Transform>().WithId(TypeTransform.TransformForTypeView).FromComponentOn(_playerTrasnform)
                .AsSingle().NonLazy();

            Container.Bind<TypeViewController>().FromSubContainerResolve().ByNewContextPrefab(_prefabTypeView)
                .UnderTransform(_playerTrasnform.transform).AsSingle().NonLazy();

            Container.BindInterfacesAndSelfTo<IWeapon>().FromSubContainerResolve().ByNewContextPrefab(_prefabWeapon)
                .UnderTransform(_containerOfScripts.transform).AsSingle().NonLazy();

            Container.Bind<IAttack>().To<AttackController>().FromComponentOn(_containerOfScripts).AsSingle()
                .NonLazy();
            
            Container.Bind<Inventory>().FromComponentOn(_containerOfScripts).AsSingle().NonLazy();
            
            Container.Bind<Player>().FromComponentOn(_containerOfScripts).AsSingle().NonLazy();
        }
    }
}