using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePaw : MonoBehaviour
{
    public float moveSpeed = 2.5f;
    public Vector3 offPosition1;
    public Vector3 onPosition1;
    public GameObject orangePaw;
    public GameObject greyPaw;
    public GameObject whitePaw;
    public GameObject brownPaw;
    public GameObject movePaws;

    //random
    public float minX, maxX, minY, maxY;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //delete if times up
        if (GameObject.Find("Timer").GetComponent<Timer>().isTimeUp == true)
        {
            Debug.Log("all paws inactive.");
            orangePaw.SetActive(false);
            greyPaw.SetActive(false);
            whitePaw.SetActive(false);
            brownPaw.SetActive(false);
            enabled = false;
        }

        //if orange claws spawned
        if (GameObject.FindGameObjectWithTag("orangeClaw") != null)
        {
            //move orange paw on screen
            orangePaw.transform.position = Vector3.MoveTowards(orangePaw.transform.position, onPosition1, moveSpeed * Time.deltaTime);
        }
        //if orange claws destroyed
        if (GameObject.FindGameObjectWithTag("orangeClaw") == null)
        {
            //move orange paw off screen
            orangePaw.transform.position = Vector3.MoveTowards(orangePaw.transform.position, offPosition1, moveSpeed * Time.deltaTime);
        }

        //if claws 2 spawned
        if (GameObject.FindGameObjectWithTag("greyClaw") != null)
        {
            //move grey paw to screen
            greyPaw.transform.position = Vector3.MoveTowards(greyPaw.transform.position, onPosition1, moveSpeed * Time.deltaTime);
        }

        //if claws 2 destroyed
        if (GameObject.FindGameObjectWithTag("greyClaw") == null)
        {
            //move grey paw off screen
            greyPaw.transform.position = Vector3.MoveTowards(greyPaw.transform.position, offPosition1, moveSpeed * Time.deltaTime);
        }

        //if claws 3 spawned
        if (GameObject.FindGameObjectWithTag("whiteClaw") != null)
        {
            //move white paw to screen
            whitePaw.transform.position = Vector3.MoveTowards(whitePaw.transform.position, onPosition1, moveSpeed * Time.deltaTime);
        }

        //if claws 3 destroyed
        if (GameObject.FindGameObjectWithTag("whiteClaw") == null)
        {
            //move white paw off screen
            whitePaw.transform.position = Vector3.MoveTowards(whitePaw.transform.position, offPosition1, moveSpeed * Time.deltaTime);
        }

        //if claws 4 spawned
        if (GameObject.FindGameObjectWithTag("brownClaw") != null)
        {
            //move brown paw to screen
            brownPaw.transform.position = Vector3.MoveTowards(brownPaw.transform.position, onPosition1, moveSpeed * Time.deltaTime);
        }

        //if claws 4 destroyed
        if (GameObject.FindGameObjectWithTag("brownClaw") == null)
        {
            //move brown paw off screen
            brownPaw.transform.position = Vector3.MoveTowards(brownPaw.transform.position, offPosition1, moveSpeed * Time.deltaTime);
        }
    }
}














