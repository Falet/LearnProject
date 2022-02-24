using System;
using GameLearnProject.ItemsComponents.Interfaces;
using GameLearnProject.ReferenceTypeForSerializedData;
using GameLearnProject.ReferenceTypeForSerializedData.ItemsData.WeaponsData;
using UnityEngine;
using Zenject;

namespace GameLearnProject.ItemsComponents.Weapons
{
    public class Bow : MonoBehaviour, IWeapon
    {
        public string NameWeapon => _bowData.NameWeapon;

        private BowData _bowData;

        [Inject]
        public void Constructor(ItemSerializedData data)
        {
            _bowData = (BowData)data;
        }

        public Guid GetGuid()
        {
            if (_bowData.GuidItem == Guid.Empty)
            {
                _bowData.GuidItem = Guid.NewGuid();
            }
            return _bowData.GuidItem;
        }
    }
}