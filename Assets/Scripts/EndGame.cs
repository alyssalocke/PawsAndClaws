using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject endMessage;
    public GameObject time;
    public GameObject score;
    public Vector3 spawnPosition;
    public Vector3 offScreen;

    void Start()
    {
        
    }

    void Update()
    {
        if (GameObject.Find("Timer").GetComponent<Timer>().isTimeUp == true)
        {
            endMessage.transform.position = spawnPosition;
            score.SetActive(false);
            time.SetActive(false);
        }
    }
}
