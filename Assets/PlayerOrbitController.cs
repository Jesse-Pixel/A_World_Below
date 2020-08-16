using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace AWorldBelow.Scripts.Input
{
    public class PlayerOrbitController : MonoBehaviour
    {
        public float rotationSpeed = 20.0f;


        public Transform _transform;
        private Vector2 _inputAxis = new Vector2();

        private void OnEnable()
        {

        }

        private void Update()
        {
            if(_inputAxis != Vector2.zero && _transform != null)
            {
                Quaternion xRotation = Quaternion.AngleAxis(-_inputAxis.x * rotationSpeed * Time.deltaTime, _transform.up);
                Quaternion yRotation = Quaternion.AngleAxis(_inputAxis.y * rotationSpeed * Time.deltaTime, _transform.forward);
                Quaternion newRotation = _transform.rotation * xRotation * yRotation;
                _transform.rotation = newRotation;

            }
        }

        public void SetInputAxis(Vector2 inputAxis)
        {
            _inputAxis = inputAxis;
        }


    }
}
