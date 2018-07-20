using System.Collections;
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
        float translation = Input.GetAxis("Vertical") * speed;

        translation *= Time.deltaTime;     

        
        transform.Translate(0, 0, translation);
    }
}
