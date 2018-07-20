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
<<<<<<< HEAD
<<<<<<< HEAD
        Instantiate(prefabs[Random.Range(0, prefabs.Length)], myTransform.position, myTransform.rotation);
=======
        Vector3 offset = new Vector3(Random.Range(1f, 5f), Random.Range(1f, 5f), Random.Range(1f, 5f));
        Instantiate(prefab, myTransform.position + offset, myTransform.rotation);
>>>>>>> 5bb1e7073cdd69d1a80833fb7ac79d6d94617163
=======
        Instantiate(prefabs[Random.Range(0, prefabs.Length)], myTransform.position, myTransform.rotation);
>>>>>>> bb37bf5d72bafe5c670cd3d8828cc16358a3ec74
    }
}
