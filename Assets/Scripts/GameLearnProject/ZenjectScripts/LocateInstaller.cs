﻿using UnityEngine;
using Zenject;

namespace GameLearnProject.ZenjectScripts
{
    public class LocateInstaller : MonoInstaller
    {
        [SerializeField] private GameObject _playerObject;

        public override void InstallBindings()
        {
            Container.Bind<Player>().FromSubContainerResolve().ByNewContextPrefab(_playerObject).AsSingle().NonLazy();
        }
    }
}