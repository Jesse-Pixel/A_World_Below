using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace AWorldBelow.Scripts.Input
{
    public class CameraOrbitController : MonoBehaviour
    {

        public Transform followOrbit;
        private Transform _transform;

        private void OnEnable()
        {
            _transform = transform;
        }

        private void Update()
        {
            _transform.rotation = followOrbit.rotation;
        }
    }
}