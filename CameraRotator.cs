using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    public float cameraRotatorSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,cameraRotatorSpeed * Time.deltaTime, 0);
    }
}
