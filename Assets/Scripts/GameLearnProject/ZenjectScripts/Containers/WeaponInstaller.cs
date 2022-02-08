using GameLearnProject.ItemsComponents;
using GameLearnProject.ItemsComponents.Interfaces;
using GameLearnProject.PawnComponents;
using UnityEngine;
using Zenject;

namespace GameLearnProject.ZenjectScripts.Containers
{
    public class WeaponInstaller : MonoInstaller
    {
        [SerializeField] private GameObject _containerForComponent;
        
        public override void InstallBindings()
        {
            Container.Bind<IMeleeWeapon>().To<Knife>().FromNewComponentOn(_containerForComponent).AsSingle().NonLazy();
            
            Container.Bind<MeleeAttack>().FromNewComponentOn(_containerForComponent).AsSingle().NonLazy();
        }
    }
}