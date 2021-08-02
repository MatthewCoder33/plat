using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeyThingGoSpawn : MonoBehaviour
{
    public GameObject coNe;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayCon playerController;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerController = GameObject.Find("guy").GetComponent<PlayCon>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnObstacle()
    {
        if (playerController.gameOver == false)
        {
            Instantiate(coNe, spawnPos, coNe.transform.rotation);
        }
    }
}