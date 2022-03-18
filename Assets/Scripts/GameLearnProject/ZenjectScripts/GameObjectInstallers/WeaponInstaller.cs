using GameLearnProject.ReferenceTypeForSerializedData;
using UnityEngine;
using Zenject;

namespace GameLearnProject.ZenjectScripts.GameObjectInstallers
{
    public class WeaponInstaller : MonoInstaller
    {
        [SerializeField] private GameObject _containerWeapon;

        private ItemSerializedData _itemSerializedData;

        [Inject]
        private void Constructor(ItemSerializedData itemSerializedData)
        {
            _itemSerializedData = itemSerializedData;
        }

        public override void InstallBindings()
        {
            Container.Bind(_itemSerializedData.GetType())
                .FromInstance(_itemSerializedData).AsSingle().NonLazy();
        }
    }
}