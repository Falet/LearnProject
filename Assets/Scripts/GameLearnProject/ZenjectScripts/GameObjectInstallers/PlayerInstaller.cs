using GameLearnProject.ItemsComponents.Interfaces;
using GameLearnProject.PawnComponents;
using GameLearnProject.PawnComponents.Interfaces;
using UnityEngine;
using UnityEngine.AI;
using Zenject;

namespace GameLearnProject.ZenjectScripts.GameObjectInstallers
{
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField] private GameObject _containerForComponents;
        [SerializeField] private GameObject _prefabWeapon;

        public override void InstallBindings()
        {
            Container.Bind<NavMeshAgent>().FromComponentOnRoot().AsSingle().NonLazy();
            Container.Bind<IMovement>().To<Movement>().FromComponentOn(_containerForComponents).AsSingle().NonLazy();
            Container.Bind<IRotation>().To<Rotation>().FromComponentOn(_containerForComponents).AsSingle().NonLazy();

            Container.BindInterfacesAndSelfTo<IWeapon>().FromSubContainerResolve().ByNewContextPrefab(_prefabWeapon)
                .UnderTransform(_containerForComponents.transform).AsSingle().NonLazy();

            Container.Bind<IAttack>().To<AttackController>().FromComponentOn(_containerForComponents).AsSingle().NonLazy();
            
            Container.Bind<Inventory>().FromComponentOn(_containerForComponents).AsSingle().NonLazy();
            
            Container.Bind<Player>().FromComponentOn(_containerForComponents).AsSingle().NonLazy();
        }
    }
}