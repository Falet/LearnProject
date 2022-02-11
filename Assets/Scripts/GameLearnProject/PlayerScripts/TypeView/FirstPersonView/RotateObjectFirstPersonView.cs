using GameLearnProject.PlayerScripts.TypeView.Interfaces;
using GameLearnProject.ZenjectScripts.GameObjectInstallers;
using UnityEngine;
using Zenject;

namespace GameLearnProject.PlayerScripts.TypeView.FirstPersonView
{
    public class RotateObjectFirstPersonView : MonoBehaviour, IRotatePawnObject
    {
        [SerializeField] private float speed;//Должно задаваться из файла конфигурации
        
        private Vector3 _rotation;
        private Transform _transformPlayer;

        [Inject]
        private void Constructor(
            [Inject(Id = TypeTransform.TransformForTypeView)]
            Transform transformPlayer)
        {
            _transformPlayer = transformPlayer;
        }

        public void Rotate(Vector2 delta)
        {
            _rotation.y += delta.x  * speed;
        }
        
        private void FixedUpdate()
        {
            _transformPlayer.transform.localEulerAngles = _rotation * Time.fixedDeltaTime;
        }
    }
}