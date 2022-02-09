using GameLearnProject.ItemsComponents.Interfaces;
using GameLearnProject.PawnComponents.Interfaces;
using UnityEngine;
using Zenject;

namespace GameLearnProject.PawnComponents
{
    public class AttackController : MonoBehaviour, IAttack
    {
        private IWeapon _weapon;

        [Inject]
        private void Constructor(IWeapon weapon)
        {
            _weapon = weapon;
        }
        
        public void Attack()
        {
            
        }
    }
}
