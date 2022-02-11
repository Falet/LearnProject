using GameLearnProject.ItemsComponents.Interfaces;
using UnityEngine;
using Zenject;

namespace GameLearnProject.ItemsComponents
{
    public class Knife : MonoBehaviour, IWeapon
    {
        public string _nameWeapon = "Knife";
        public string NameWeapon => _nameWeapon;
        
        [Inject]
        private void Constructor()
        {
            
        }
    }
}
