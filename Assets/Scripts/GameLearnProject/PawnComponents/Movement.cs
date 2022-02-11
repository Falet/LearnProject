using GameLearnProject.PawnComponents.Interfaces;
using UnityEngine;
using Zenject;

namespace GameLearnProject.PawnComponents
{
    public class Movement : MonoBehaviour, IMovement
    {
        [SerializeField] private float speed;
        [SerializeField] private Transform _transformForMove;

        private Vector3 _currentChanges;

        [Inject]
        private void Constructor()
        {
            
        }
        
        public void Move(Vector2 changeMovement)
        {
            _currentChanges.x = changeMovement.x;
            _currentChanges.z = changeMovement.y;
        }
        
        private void FixedUpdate()
        {
            _transformForMove.Translate(_currentChanges * speed * Time.fixedDeltaTime);
        }
    }
}
