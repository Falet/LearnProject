using GameLearnProject.PlayerScripts.TypeView.Interfaces;
using UnityEngine;
using Zenject;

namespace GameLearnProject.PlayerScripts.TypeView
{
    public class TypeViewController : MonoBehaviour
    {
        private IMovementPawnCamera _movementPawnCamera;
        private IMovementPawnObject _movementPawnObject;
        private IRotationPawnCamera _rotationPawnCamera;
        private IRotatePawnObject _rotatePawnObject;

        [Inject]
        private void Constructor(IMovementPawnCamera movementPawnCamera, IMovementPawnObject movementPawnObject,
            IRotationPawnCamera rotationPawnCamera, IRotatePawnObject rotatePawnObject)
        {
            _rotatePawnObject = rotatePawnObject;
            _rotationPawnCamera = rotationPawnCamera;
            _movementPawnObject = movementPawnObject;
            _movementPawnCamera = movementPawnCamera;
        }

        public void ChangePointerPosition(Vector2 delta)
        {
            _rotatePawnObject.Rotate(delta);
            _rotationPawnCamera.Rotate(delta);
        }
        
        public void ChangeMovementVector(Vector2 changes)
        {
            _movementPawnObject.Move(changes);
        }
    }
}