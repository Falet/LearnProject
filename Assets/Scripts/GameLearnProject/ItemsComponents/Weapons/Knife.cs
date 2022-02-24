using System;
using GameLearnProject.ItemsComponents.Interfaces;
using GameLearnProject.ReferenceTypeForSerializedData;
using GameLearnProject.ReferenceTypeForSerializedData.ItemsData.WeaponsData;
using UnityEngine;
using Zenject;

namespace GameLearnProject.ItemsComponents.Weapons
{
    public class Knife : MonoBehaviour, IWeapon
    {
        private KnifeData _knifeData;
        
        public string NameWeapon => _knifeData.NameWeapon;

        [Inject]
        public void Constructor(ItemSerializedData data)
        {
            _knifeData = (KnifeData)data;
        }

        public Guid GetGuid()
        {
            if (_knifeData.GuidItem == Guid.Empty)
            {
                _knifeData.GuidItem = Guid.NewGuid();
            }
            return _knifeData.GuidItem;
        }
    }
}
