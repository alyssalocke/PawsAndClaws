using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnClaws : MonoBehaviour
{
    public float moveSpeed = 2.5f;
    //public Vector3 offScreen;

    //bools to control next claw spawned
    private bool isOrangeClawSpawned = false;
    private bool isGreyClawSpawned = false;
    private bool isWhiteClawSpawned = false;
    private bool isBrownClawSpawned = false;

    //spawn points for claw. is there a better way? maybe somehow parented to paw?
    public Vector3 claw1Spawn;
    public Vector3 claw2Spawn;
    public Vector3 claw3Spawn;
    public Vector3 claw4Spawn;
    public Vector3 claw5Spawn;

    //game objects
    public GameObject claw1;
    public GameObject claw2;
    public GameObject claw3;
    public GameObject claw4;
    public GameObject claw5;
    public GameObject orangePaw;
    public GameObject greyPaw;
    public GameObject whitePaw;
    public GameObject brownPaw;
    public GameObject spawnClaws;

    void Start()
    {
        claw1.SetActive(true);
        claw2.SetActive(true);
        claw3.SetActive(true);
        claw4.SetActive(true);
        claw5.SetActive(true);
    }

    void Update()
    {
        //if times up
        if (GameObject.Find("Timer").GetComponent<Timer>().isTimeUp == true)
        {
            Debug.Log("all claws inactive.");
            claw1.SetActive(false);
            claw2.SetActive(false);
            claw3.SetActive(false);
            claw4.SetActive(false);
            claw5.SetActive(false);
            isOrangeClawSpawned = true;
            enabled = false;
        }

        //orange claws spawn
        if (GameObject.FindGameObjectWithTag("brownClaw") == null && isOrangeClawSpawned == false)
        {
            Debug.Log("orange claws spawned");
            GameObject claw1C = Instantiate(claw1, claw1Spawn, transform.rotation) as GameObject;
            claw1C.gameObject.tag = "orangeClaw";
            claw1C.transform.parent = orangePaw.transform;
            GameObject claw2C = Instantiate(claw2, claw2Spawn, transform.rotation) as GameObject;
            claw2C.gameObject.tag = "orangeClaw";
            claw2C.transform.parent = orangePaw.transform;
            GameObject claw3C = Instantiate(claw3, claw3Spawn, transform.rotation) as GameObject;
            claw3C.gameObject.tag = "orangeClaw";
            claw3C.transform.parent = orangePaw.transform;
            GameObject claw4C = Instantiate(claw4, claw4Spawn, transform.rotation) as GameObject;
            claw4C.gameObject.tag = "orangeClaw";
            claw4C.transform.parent = orangePaw.transform;
            GameObject claw5C = Instantiate(claw5, claw5Spawn, transform.rotation) as GameObject;
            claw5C.gameObject.tag = "orangeClaw";
            claw5C.transform.parent = orangePaw.transform;
            isOrangeClawSpawned = true;
            isGreyClawSpawned = false;
        }

        //grey claws spawn
        if (GameObject.FindGameObjectWithTag("orangeClaw") == null && isGreyClawSpawned == false)
        {
            Debug.Log("grey claws spawned");
            GameObject claw1C = Instantiate(claw1, claw1Spawn, transform.rotation) as GameObject;
            claw1C.gameObject.tag = "greyClaw";
            claw1C.transform.parent = greyPaw.transform;
            GameObject claw2C = Instantiate(claw2, claw2Spawn, transform.rotation) as GameObject;
            claw2C.gameObject.tag = "greyClaw";
            claw2C.transform.parent = greyPaw.transform;
            GameObject claw3C = Instantiate(claw3, claw3Spawn, transform.rotation) as GameObject;
            claw3C.gameObject.tag = "greyClaw";
            claw3C.transform.parent = greyPaw.transform;
            GameObject claw4C = Instantiate(claw4, claw4Spawn, transform.rotation) as GameObject;
            claw4C.gameObject.tag = "greyClaw";
            claw4C.transform.parent = greyPaw.transform;
            GameObject claw5C = Instantiate(claw5, claw5Spawn, transform.rotation) as GameObject;
            claw5C.gameObject.tag = "greyClaw";
            claw5C.transform.parent = greyPaw.transform;
            isGreyClawSpawned = true;
            isWhiteClawSpawned = false;
        }
        //white claws spawn
        if (GameObject.FindGameObjectWithTag("orangeClaw") == null && GameObject.FindGameObjectWithTag("greyClaw") == null && isWhiteClawSpawned == false)
        {
            Debug.Log("white claws spawned");
            GameObject claw1C = Instantiate(claw1, claw1Spawn, transform.rotation) as GameObject;
            claw1C.gameObject.tag = "whiteClaw";
            claw1C.transform.parent = whitePaw.transform;
            GameObject claw2C = Instantiate(claw2, claw2Spawn, transform.rotation) as GameObject;
            claw2C.gameObject.tag = "whiteClaw";
            claw2C.transform.parent = whitePaw.transform;
            GameObject claw3C = Instantiate(claw3, claw3Spawn, transform.rotation) as GameObject;
            claw3C.gameObject.tag = "whiteClaw";
            claw3C.transform.parent = whitePaw.transform;
            GameObject claw4C = Instantiate(claw4, claw4Spawn, transform.rotation) as GameObject;
            claw4C.gameObject.tag = "whiteClaw";
            claw4C.transform.parent = whitePaw.transform;
            GameObject claw5C = Instantiate(claw5, claw5Spawn, transform.rotation) as GameObject;
            claw5C.gameObject.tag = "whiteClaw";
            claw5C.transform.parent = whitePaw.transform;
            isWhiteClawSpawned = true;
            isBrownClawSpawned = false;
        }
        //brown claws spawn
        if (GameObject.FindGameObjectWithTag("orangeClaw") == null && GameObject.FindGameObjectWithTag("greyClaw") == null && GameObject.FindGameObjectWithTag("whiteClaw") == null && isBrownClawSpawned == false)
        {
            Debug.Log("brown claws spawned");
            GameObject claw1C = Instantiate(claw1, claw1Spawn, transform.rotation) as GameObject;
            claw1C.gameObject.tag = "brownClaw";
            claw1C.transform.parent = brownPaw.transform;
            GameObject claw2C = Instantiate(claw2, claw2Spawn, transform.rotation) as GameObject;
            claw2C.gameObject.tag = "brownClaw";
            claw2C.transform.parent = brownPaw.transform;
            GameObject claw3C = Instantiate(claw3, claw3Spawn, transform.rotation) as GameObject;
            claw3C.gameObject.tag = "brownClaw";
            claw3C.transform.parent = brownPaw.transform;
            GameObject claw4C = Instantiate(claw4, claw4Spawn, transform.rotation) as GameObject;
            claw4C.gameObject.tag = "brownClaw";
            claw4C.transform.parent = brownPaw.transform;
            GameObject claw5C = Instantiate(claw5, claw5Spawn, transform.rotation) as GameObject;
            claw5C.gameObject.tag = "brownClaw";
            claw5C.transform.parent = brownPaw.transform;
            isBrownClawSpawned = true;
            isOrangeClawSpawned = false;
        }
    }

    
}
