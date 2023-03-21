using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public AudioClip audioClip;
    public Vector3 offPos = new Vector3(-1, -3, 0);

    private AudioSource audioSource;

    void Start()
    {
        GameObject audioObj = GameObject.Find("CutSound");
        audioObj.transform.position = offPos;

        if (audioObj == null)
        {
            audioObj = new GameObject("CutSound");
            audioSource = audioObj.AddComponent<AudioSource>();
        }
        else
        {
            audioSource = audioObj.GetComponent<AudioSource>();
        }
    }

    private void OnMouseDown()
    {
        Debug.Log("+1 score");
        int increment = 1;
        GameObject.FindGameObjectWithTag("ScoreHandler").SendMessage("UpdateScore", increment);
        Debug.Log("destroyed " + gameObject.name);
        Destroy(gameObject);
        audioSource.PlayOneShot(audioClip);
    }
}
