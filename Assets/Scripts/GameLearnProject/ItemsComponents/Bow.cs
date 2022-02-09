using GameLearnProject.ItemsComponents.Interfaces;
using UnityEngine;
using Zenject;

namespace GameLearnProject.ItemsComponents
{
    public class Bow : MonoBehaviour, IWeapon
    {
        public string NameWeapon { get; }

        private Player _player;

        [Inject]
        private void Constructor(Player player)
        {
            _player = player;
        }
    }
}