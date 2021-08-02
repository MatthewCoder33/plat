using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCon : MonoBehaviour
{
    private Rigidbody RBplayer;
    public ParticleSystem explosionParticle;
    public ParticleSystem dort;
    public float jumpforce;
    public float gravMods;
    public bool isOnGround = true;
    public bool gameOver = false;
    private Animator playerAnim;
    public AudioClip industrialSociety;
    public AudioClip moGus;
    private AudioSource pog;

    // Start is called before the first frame update
    void Start()
    {
        RBplayer = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        Physics.gravity *= gravMods;
        pog = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            RBplayer.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
            dort.Stop();
            pog.PlayOneShot(industrialSociety);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            isOnGround = true;
            dort.Play();
        }

        else if (collision.gameObject.CompareTag("thing that hurts you or something"))
        {
            gameOver = true;
            Debug.Log("bruh");
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
            dort.Stop();
            pog.PlayOneShot(moGus);
        }
    }
}
