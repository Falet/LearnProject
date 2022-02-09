using GameLearnProject.PawnComponents.Interfaces;
using UnityEngine;
using Zenject;

namespace GameLearnProject
{
    public class Player : MonoBehaviour
    {
        private IMovement _movement;
        private IRotation _rotation;
        private IAttack _attack;
        
        private Inventory _inventory;
        
        [Inject]
        private void Constructor(IMovement movement, IRotation rotation, IAttack attack, Inventory inventory)
        {
            _movement = movement;
            _rotation = rotation;
            _attack = attack;
            _inventory = inventory;
        }
    }
}
