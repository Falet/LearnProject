using GameLearnProject.PlayerScripts;
using UnityEngine;
using Zenject;

namespace GameLearnProject.ZenjectScripts.SceneInstallers
{
    public class LocateInstaller : MonoInstaller
    {
        [SerializeField] private GameObject _playerObject;
        [SerializeField] private GameObject _prefabContainerForLoot;

        public override void InstallBindings()
        {
            Container.Bind<Player>().FromSubContainerResolve().ByNewContextPrefab(_playerObject).AsSingle().NonLazy();
            //Container.Bind<IContainer>().FromSubContainerResolve().ByNewContextPrefab(_prefabContainerForLoot).AsSingle().NonLazy();
        }
    }
}