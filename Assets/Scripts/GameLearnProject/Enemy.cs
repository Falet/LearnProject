using GameLearnProject.PawnComponents.Interfaces;
using UnityEngine;
using Zenject;

namespace GameLearnProject
{
    public class Enemy : MonoBehaviour
    {
        private IMovement _movement;
        private IRotation _rotation;
        private IAttack _attack;
        
        [Inject]
        private void Constructor(IMovement movement, IRotation rotation, IAttack attack)
        {
            _movement = movement;
            _rotation = rotation;
            _attack = attack;
        }
    }
}
