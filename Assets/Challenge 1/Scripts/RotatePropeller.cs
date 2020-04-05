using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePropeller : MonoBehaviour
{
    private float propSpeed = 1000;
    void Update()
    {
        transform.Rotate(Vector3.forward, propSpeed * Time.deltaTime);
    }

}
