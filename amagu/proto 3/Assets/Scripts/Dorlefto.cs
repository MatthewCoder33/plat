using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dorlefto : MonoBehaviour
{
    private float speed = 30;
    private PlayCon playerControllerScript;
    private float leftBound = -15;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("guy").GetComponent<PlayCon>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("thing that hurts you or something"))
        {
            Destroy(gameObject);
        }
    }
}