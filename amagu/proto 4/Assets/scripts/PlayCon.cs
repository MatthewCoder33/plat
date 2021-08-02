using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCon : MonoBehaviour
{
    private GameObject foPo;
    public float speed = 5.0f;
    private Rigidbody Rbp;
    public float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        Rbp = GetComponent<Rigidbody>();
        foPo = GameObject.Find("da point that is a point and is focal");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        Rbp.AddForce(Vector3.forward * speed * forwardInput);

        float horizontalInput = Input.GetAxis("Horizontal");
        Rbp.AddForce(Vector3.right * speed * horizontalInput);
    }
}
