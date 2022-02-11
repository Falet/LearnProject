using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace GameLearnProject.Input
{
    public class InputManager : MonoBehaviour
    {
        private GameInput _inputActions;

        public event EventHandler<Vector2> ChangedMovementInput;
        public event EventHandler<Vector2> ChangedPositionPointer;
        public event EventHandler Attacked;
        
        private void Awake()
        {
            _inputActions = new GameInput();

            _inputActions.Player.Move.canceled += MoveOnStarted;
            _inputActions.Player.Move.performed += MoveOnStarted;

            _inputActions.Player.Look.canceled += LookOnPerformed;
            _inputActions.Player.Look.performed += LookOnPerformed;
            
            _inputActions.Player.Attack.performed += AttackOnPerformed;
        }

        private void AttackOnPerformed(InputAction.CallbackContext obj)
        {
            Attacked?.Invoke(this, EventArgs.Empty);
        }

        private void OnEnable()
        {
            _inputActions.Enable();
        }
        
        private void OnDisable()
        {
            _inputActions.Disable();
        }

        private void LookOnPerformed(InputAction.CallbackContext obj)
        {
            ChangedPositionPointer?.Invoke(this, obj.ReadValue<Vector2>());
        }
        
        private void MoveOnStarted(InputAction.CallbackContext obj)
        {
            ChangedMovementInput?.Invoke(this, obj.ReadValue<Vector2>());
        }
    }
}