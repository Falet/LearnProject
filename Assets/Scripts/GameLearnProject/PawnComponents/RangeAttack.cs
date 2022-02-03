using GameLearnProject.ItemsComponents.Interfaces;
using GameLearnProject.PawnComponents.Interfaces;
using UnityEngine;
using Zenject;

namespace GameLearnProject.PawnComponents
{
    public class RangeAttack : MonoBehaviour, IAttack
    {
        private IRangeWeapon _weapon;

        [Inject]
        private void Constructor(IRangeWeapon weapon)
        {
            _weapon = weapon;
        }

        
        public void Attack()
        {
        }
    }
}