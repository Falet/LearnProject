using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace GameLearnProject.Input
{
    public class InputManager : MonoBehaviour
    {
        private DefaultInputActions _inputActions;

        public event EventHandler Move;
        
        private void Awake()
        {
            _inputActions = new DefaultInputActions();
            
            _inputActions.Player.Move.performed += MoveOnstarted;
        }

        private void OnEnable()
        {
            _inputActions.Enable();
        }

        private void OnDisable()
        {
            _inputActions.Disable();
        }

        private void MoveOnstarted(InputAction.CallbackContext obj)
        {
            
        }
    }
}