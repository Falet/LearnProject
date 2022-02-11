using System;
using GameLearnProject.Input;
using GameLearnProject.PawnComponents;
using GameLearnProject.PawnComponents.Interfaces;
using GameLearnProject.PlayerScripts.TypeView;
using UnityEngine;
using Zenject;

namespace GameLearnProject.PlayerScripts
{
    public class Player : MonoBehaviour
    {
        private IAttack _attack;
        
        private Inventory _inventory;
        private InputManager _input;
        private TypeViewController _typeViewController;

        [Inject]
        private void Constructor(TypeViewController typeViewController, IAttack attack, Inventory inventory, InputManager input)
        {
            _typeViewController = typeViewController;
            _attack = attack;
            _inventory = inventory;
            _input = input;
            _input.ChangedMovementInput += OnChangedMovementInput;
            _input.ChangedPositionPointer += OnChangedPositionPointer;
            _input.Attacked += OnAttacked;
        }

        private void OnAttacked(object sender, EventArgs e)
        {
            _attack.Attack();
        }

        private void OnChangedPositionPointer(object sender, Vector2 e)
        {
            _typeViewController.ChangePointerPosition(e);
        }

        private void OnChangedMovementInput(object sender, Vector2 e)
        {
            _typeViewController.ChangeMovementVector(e);
        }
    }
}
