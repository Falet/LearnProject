using GameLearnProject.PawnComponents.Interfaces;
using UnityEngine;
using Zenject;

namespace GameLearnProject.ZenjectScripts.Containers
{
    public class PlayerContainer : MonoInstaller
    {
        private IMovement _movement;
        
        private void Awake()
        {
            _movement = GetComponentInChildren<IMovement>();
        }

        public override void InstallBindings()
        {
            Debug.Log(1);
        }
    }
}