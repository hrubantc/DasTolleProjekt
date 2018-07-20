using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {


    public GameObject[] prefabs;
    public float intervalInSeconds = 0.1f;

    Transform myTransform;

	void Start () {
        myTransform = transform;
        InvokeRepeating("SpawnPrefab", 0f, intervalInSeconds);
	}
	
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnPrefab();
        }
	}

    public void SpawnPrefab()
    {

        Instantiate(prefabs[Random.Range(0, prefabs.Length)], myTransform.position, myTransform.rotation);
    }
}
