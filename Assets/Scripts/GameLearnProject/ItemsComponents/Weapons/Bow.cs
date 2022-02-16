using System;
using GameLearnProject.ItemsComponents.Interfaces;
using GameLearnProject.ItemsComponents.Weapons.WeaponsData;
using GameLearnProject.ReferenceTypeForSerializedData;
using UnityEngine;
using Zenject;

namespace GameLearnProject.ItemsComponents.Weapons
{
    public class Bow : MonoBehaviour, IWeapon
    {
        public string NameWeapon => _bowData.NameWeapon;

        private BowData _bowData;

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
            _bowData = (BowData) data;
        }
    }
}