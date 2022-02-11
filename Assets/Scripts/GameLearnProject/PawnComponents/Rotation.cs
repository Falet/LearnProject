using GameLearnProject.PawnComponents.Interfaces;
using UnityEngine;
using Zenject;

namespace GameLearnProject.PawnComponents
{
    public class Rotation : MonoBehaviour, IRotation
    {
        [SerializeField] private float speed;
        [SerializeField] private GameObject _rootForRotation;
        
        private Vector3 _rotation;

        [Inject]
        private void Constructor()
        {
            
        }
        
        public void Rotate(Vector2 delta)
        {
            _rotation.y += delta.x  * speed;
            _rotation.x += -delta.y  * speed;
        }

        private void FixedUpdate()
        {
            _rootForRotation.transform.localEulerAngles = _rotation * Time.fixedDeltaTime;
        }
    }
}
