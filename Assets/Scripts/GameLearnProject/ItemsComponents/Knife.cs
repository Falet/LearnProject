using GameLearnProject.ItemsComponents.Interfaces;
using UnityEngine;
using Zenject;

namespace GameLearnProject.ItemsComponents
{
    public class Knife : MonoBehaviour, IWeapon
    {
        public string _nameWeapon = "Knife";
        public string NameWeapon => _nameWeapon;
        
        private Player _player;

        [Inject]
        private void Constructor(Player player)
        {
            _player = player;
            
        }
    }
}
