using System;
using GameLearnProject.ItemsComponents.Interfaces;
using GameLearnProject.ItemsComponents.Weapons.WeaponsData;
using GameLearnProject.ReferenceTypeForSerializedData;
using UnityEngine;
using Zenject;

namespace GameLearnProject.ItemsComponents.Weapons
{
    public class Knife : MonoBehaviour, IWeapon
    {
        private KnifeData _knifeData;
        
        public string NameWeapon => _knifeData.NameWeapon;
        
        [Inject]
        private void Constructor()
        {
            
        }

        public Guid GetGuid()
        {
            return Guid.NewGuid();
        }

        public void SetData(ItemSerializedData data)
        {
            _knifeData = (KnifeData) data;
        }
    }
}
