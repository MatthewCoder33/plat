using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOOB : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
    //if you take an L
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            Debug.Log("bruh");
        }
    }
}
