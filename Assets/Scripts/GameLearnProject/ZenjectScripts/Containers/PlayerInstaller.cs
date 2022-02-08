using GameLearnProject.PawnComponents;
using GameLearnProject.PawnComponents.Interfaces;
using UnityEngine;
using UnityEngine.AI;
using Zenject;

namespace GameLearnProject.ZenjectScripts.Containers
{
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField] private GameObject _containerForComponents;
        [SerializeField] private GameObject _prefabWeapon;

        public override void InstallBindings()
        {
            Container.Bind<NavMeshAgent>().FromNewComponentOn(_containerForComponents).AsSingle().NonLazy();
            Container.Bind<IMovement>().To<Movement>().FromNewComponentOn(_containerForComponents).AsSingle().NonLazy();
            Container.Bind<IRotation>().To<Rotation>().FromNewComponentOn(_containerForComponents).AsSingle().NonLazy();
            
            Container.Bind<IAttack>().To<MeleeAttack>().FromSubContainerResolve().ByNewContextPrefab(_prefabWeapon).AsSingle().NonLazy();
            
            Container.Bind<Inventory>().FromNewComponentOn(_containerForComponents).AsSingle().NonLazy();
            
            Container.Bind<Player>().FromNewComponentOn(_containerForComponents).AsSingle().NonLazy();
        }
    }
}