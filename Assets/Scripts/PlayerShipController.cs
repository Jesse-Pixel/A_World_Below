using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace AWorldBelow.Scripts.Input
{
    public class PlayerShipController : MonoBehaviour
    {
        private ShipInput _inputActions;

        public CapsulOrbitScript orbitController;

        private void Awake()
        {
            _inputActions = new ShipInput();
        }

        private void OnEnable()
        {
            _inputActions.Enable();
            _inputActions.Ship.Shoot.performed += OnShootButton;
            _inputActions.Ship.Movement.performed += OnShipMove;
           
        }

        private void OnDisable()
        {
            _inputActions.Ship.Shoot.performed -= OnShootButton;
            _inputActions.Ship.Movement.performed -= OnShipMove;
            _inputActions.Disable();
        }

        private void OnShootButton(InputAction.CallbackContext context)
        {
            float inputValue = context.ReadValue<float>();
            Debug.Log("Shoot Button Pressed: " + inputValue);
        }

        private void OnShipMove (InputAction.CallbackContext context)
        {
            Vector2 inputValue = context.ReadValue<Vector2>();

            orbitController.SetInputAxis(inputValue);
        }

    }
}
