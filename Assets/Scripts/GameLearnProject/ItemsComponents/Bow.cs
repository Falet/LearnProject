using GameLearnProject.ItemsComponents.Interfaces;
using UnityEngine;
using Zenject;

namespace GameLearnProject.ItemsComponents
{
    public class Bow : MonoBehaviour, IWeapon
    {
        public string NameWeapon { get; }

        [Inject]
        private void Constructor()
        {
            
        }
    }
}