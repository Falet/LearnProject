using GameLearnProject.PlayerScripts.TypeView.Interfaces;
using UnityEngine;
using Zenject;

namespace GameLearnProject.PlayerScripts.TypeView.FirstPersonView
{
    public class RotateCameraFirstPersonView : MonoBehaviour, IRotationPawnCamera
    {
        [SerializeField] private float speed;//Должно задаваться из файла конфигурации
        
        private Vector3 _rotation;
        private Camera _playerCamera;

        [Inject]
        private void Constructor(Camera playerCamera)
        {
            _playerCamera = playerCamera;
        }

        public void Rotate(Vector2 delta)
        {
            _rotation.x += -delta.y  * speed;
        }
        
        private void FixedUpdate()
        {
            _playerCamera.transform.localEulerAngles = _rotation * Time.fixedDeltaTime;
        }
    }
}