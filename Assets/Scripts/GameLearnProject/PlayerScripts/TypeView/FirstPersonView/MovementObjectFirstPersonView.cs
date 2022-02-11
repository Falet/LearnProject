using GameLearnProject.PlayerScripts.TypeView.Interfaces;
using GameLearnProject.ZenjectScripts.GameObjectInstallers;
using UnityEngine;
using Zenject;

namespace GameLearnProject.PlayerScripts.TypeView.FirstPersonView
{
    public class MovementObjectFirstPersonView : MonoBehaviour, IMovementPawnObject
    {
        [SerializeField] private float speed;//Должно задаваться из файла конфигурации
        
        private Vector3 _currentChanges;
        private Transform _transformPlayer;

        [Inject]
        private void Constructor(
            [Inject(Id = TypeTransform.TransformForTypeView)]
            Transform transformPlayer)
        {
            _transformPlayer = transformPlayer;
        }

        public void Move(Vector2 changes)
        {
            _currentChanges.x = changes.x;
            _currentChanges.z = changes.y;
        }
        
        private void FixedUpdate()
        {
            _transformPlayer.Translate(_currentChanges * speed * Time.fixedDeltaTime);
        }
    }
}