using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace AWorldBelow.Scripts.Input
{
    public class CapsulOrbitScript : MonoBehaviour
    {
        // Start is called before the first frame update
        public Vector3 rotationPoint = new Vector3();
        public float rotationDistance = 21f;
        public float rotationSpeed = 20f;

        public Transform cameraTransform;

        //private Quaternion currentRotation = new Quaternion();

        Vector2 _inputAxis = new Vector2();

        public void SetInputAxis(Vector2 inputAxis)
        {
            _inputAxis = inputAxis;
        }

        private void OnEnable()
        {
            transform.position = transform.forward * rotationDistance + rotationPoint;
        }

        // Update is called once per frame
        void Update()
        {
            if(_inputAxis != Vector2.zero)
            {
                Vector3 axisOfRotation = transform.TransformDirection(new Vector3(-_inputAxis.y, -_inputAxis.x, 0.0f));
                transform.RotateAround(rotationPoint, axisOfRotation, rotationSpeed * Time.deltaTime);
            }
           
            transform.position = transform.forward * rotationDistance + rotationPoint;
        }


    }

}
