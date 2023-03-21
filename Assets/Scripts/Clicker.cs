using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    public AudioSource angryMeow;

    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    public bool isDead = false;
    public bool threeLives = true;
    public bool twoLives = false;
    public bool oneLives = false;

    private int lives = 3;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null)
            {
                Debug.Log("Lost a life");
                angryMeow.Play();
                --lives;
            }
        }
        if (lives == 2)
        {
            Destroy(heart3);
        }
        if (lives == 1)
        {
            Destroy(heart2);
        }
        if (lives == 0)
        {
            Destroy(heart1);
            isDead = true;
        }
        
    }
}