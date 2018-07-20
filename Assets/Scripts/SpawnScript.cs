using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {


    public GameObject prefab;
    public float intervalInSeconds = 0.1f;

    Transform myTransform;

	void Start () {
        myTransform = transform;
        InvokeRepeating("SpawnPrefab", 0f, intervalInSeconds);
	}
	
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("You are crazy!");
            SpawnPrefab();
        }
	}

    public void SpawnPrefab()
    {
        Vector3 offset = new Vector3(Random.Range(1f, 5f), Random.Range(1f, 5f), Random.Range(1f, 5f));
        Instantiate(prefab, myTransform.position + offset, myTransform.rotation);
    }
}
