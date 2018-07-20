﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sebnesCubeMovement : MonoBehaviour {

    float speed = 10f;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        float yTranslation = Input.GetAxis("Vertical") * speed;
        float xTranslation = Input.GetAxis("Vertical") * speed;

        yTranslation *= Time.deltaTime;
        xTranslation *= Time.deltaTime;


        transform.Translate(0, 0, xTranslation);
        transform.Translate(0, 0, yTranslation);
    }
}
