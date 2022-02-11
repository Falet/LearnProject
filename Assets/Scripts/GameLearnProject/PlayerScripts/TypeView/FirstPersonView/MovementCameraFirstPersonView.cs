using GameLearnProject.PlayerScripts.TypeView.Interfaces;
using UnityEngine;
using Zenject;

namespace GameLearnProject.PlayerScripts.TypeView.FirstPersonView
{
    public class MovementCameraFirstPersonView : MonoBehaviour, IMovementPawnCamera
    {
        [Inject]
        private void Constructor(Camera playerCamera)
        {
            
        }

        public void Move(Vector2 changes)
        {
        }
    }
}