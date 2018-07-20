using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EpilepsyController : MonoBehaviour
{
    public float pauseInterval;
    public float pauseLength;

    private Material mat;
    private bool paused = false;


    void Start()
    {
        mat = GetComponent<MeshRenderer>().material;
        StartCoroutine(PauseBlink());
    }

    void FixedUpdate ()
    {
        if (!paused)
            mat.color = Random.ColorHSV();
	}

    IEnumerator PauseBlink()
    {
        yield return new WaitForSeconds(pauseInterval);
        paused = true;
        StartCoroutine(ResumeBlink());
    }

    IEnumerator ResumeBlink()
    {
        yield return new WaitForSeconds(pauseLength);
        paused = false;
        StartCoroutine(PauseBlink());
    }
}
