using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBasedOrbit : MonoBehaviour
{
    private Vector2 InputAxis;

    private void OnEnable()
    {
        
    }

    public void SetInputAxis(Vector2 axis)
    {
        InputAxis = axis;
    }


}
