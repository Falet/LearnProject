using UnityEngine;
using Zenject;

namespace GameLearnProject.ZenjectScripts
{
    public class LocateInstaller : MonoInstaller
    {
        [SerializeField] private Player _player;

        public override void InstallBindings()
        {
            _player = Container.InstantiatePrefabForComponent<Player>(_player);
            
            
        }
    }
}