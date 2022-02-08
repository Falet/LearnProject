using GameLearnProject.ItemsComponents.Interfaces;
using GameLearnProject.PawnComponents.Interfaces;
using UnityEngine;
using Zenject;

namespace GameLearnProject.PawnComponents
{
    public class MeleeAttack : MonoBehaviour, IAttack
    {
        private IMeleeWeapon _weapon;

        [Inject]
        private void Constructor(IMeleeWeapon weapon)
        {
            _weapon = weapon;

            Debug.Log(weapon.NameWeapon);  
        }
        
        public void Attack()
        {
            
        }
    }
}
