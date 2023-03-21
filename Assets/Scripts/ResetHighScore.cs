using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetHighScore : MonoBehaviour
{
    public GameObject resetButton;
    public Vector3 spawnPos;

    public void ResetPlayerPrefs()
    {
        Debug.Log("high score reset.");
        PlayerPrefs.DeleteAll();
    }
    public void SpawnResetMessage()
    {
        resetButton.transform.position = spawnPos;
    }
}
