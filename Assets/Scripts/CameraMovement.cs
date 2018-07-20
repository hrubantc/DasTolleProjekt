using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float speed;

    private Transform camTransform;


    void Start()
    {
        camTransform = transform;
    }

    void FixedUpdate ()
    {
        camTransform.Rotate(Vector3.up, Time.fixedDeltaTime * speed);
	}
}
