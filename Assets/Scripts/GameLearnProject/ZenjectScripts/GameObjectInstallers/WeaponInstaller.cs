using GameLearnProject.ItemsComponents.Interfaces;
using UnityEngine;
using Zenject;

namespace GameLearnProject.ZenjectScripts.GameObjectInstallers
{
    public class WeaponInstaller : MonoInstaller
    {
        [SerializeField] private GameObject _containerWeapon;
        
        public override void InstallBindings()
        {
            Container.Bind<IWeapon>().FromInstance(_containerWeapon.GetComponent<IWeapon>()).AsSingle().NonLazy();
        }
    }
}