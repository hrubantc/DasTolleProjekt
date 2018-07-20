using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EpilepsyController : MonoBehaviour
{
    public float pauseInterval;
    public float pauseLength;
    public bool randomPauses = false; //Randomises the pause values after every pause

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

        if (randomPauses)
        {
            pauseInterval = Random.Range(0.1f, 2f);
            pauseLength = Random.Range(0.1f, 2f);
        }

        StartCoroutine(ResumeBlink());
    }

    IEnumerator ResumeBlink()
    {
        yield return new WaitForSeconds(pauseLength);
        paused = false;
        StartCoroutine(PauseBlink());
    }
}
