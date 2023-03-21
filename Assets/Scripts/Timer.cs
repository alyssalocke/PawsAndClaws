using System.Collections;
using System.Collections.Generic;
using System.Security.Claims;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public int timeOnStart = 15;
    public TextMeshProUGUI timeText;
    int _counter;
    public bool isTimeUp = false;


    private void Start()
    {

    }
    private void Update()
    {
        if (GameObject.Find("Clicker").GetComponent<Clicker>().isDead == true)
        {
            isTimeUp = true;
        }
    }

    void OnEnable()
    {
        timeText.text = $"Time Left: --";
        ClockStart();
    }

    void OnDisable()
    {
        ClockStop();
    }

    public void ClockStart()
    {
        _counter = timeOnStart;
        UpdateText();
        InvokeRepeating(
            nameof(ClockTick),
            1f,// the very first tick after 1 second
            1f// 1 second between every tick
        );
    }

    public void ClockStop()
    {
        CancelInvoke(nameof(ClockTick));
    }
    void ClockTick()
    {
        _counter--;
        UpdateText();

        if (_counter <= 0)
        {
            isTimeUp = true;
            Debug.Log("Time's up.");
            ClockStop();
        }
    }
    void UpdateText()
    {
        timeText.text = $"Time: {Mathf.Round(_counter)}";
    }
}