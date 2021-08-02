using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 30.0f;
    private float turnSpeed = 40.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //car go fas or slow
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //car go lef or rrrrr
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}   