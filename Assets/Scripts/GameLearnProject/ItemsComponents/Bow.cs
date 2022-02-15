using System;
using GameLearnProject.ItemsComponents.Interfaces;
using UnityEngine;
using Zenject;

namespace GameLearnProject.ItemsComponents
{
    public class Bow : MonoBehaviour, IWeapon
    {
        public string NameWeapon { get; }

        private Guid _guid;

        [Inject]
        private void Constructor()
        {
            
        }

        public void Init()
        {
            
        }

        public Guid GetGuid()
        {
            return _guid;
        }
    }
}