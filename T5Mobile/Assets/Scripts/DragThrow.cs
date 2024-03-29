﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DragThrow : MonoBehaviour
{

    Vector2 startPos;
    Vector2 endPos;
    Vector2 direction;

    float touchTimeStart;
    float touchTimeFinish;
    float timeInterval;

    Rigidbody2D rb;

    public bool throwAllowed = true;

    public float throwForce = 0.3f;

    public AudioClip ballHit;
    public AudioClip ballBounce;
    public AudioClip bouncy;
    public AudioClip whistle;
    public AudioClip soccerWin;
    public AudioClip soccerHit;
    private AudioSource audioSource;
    private AudioSource audioSourceBounce;

    public float whistleVolume;

    public TextMeshProUGUI readyText;
    public TextMeshProUGUI waitText;

    // resetting player position
    private Vector2 previousSpot;


    // Level Setting
   
    public  bool golfLevel = true;
    public  bool soccerLevel;

    //prefabs
    public GameObject golfStuff;
    public GameObject soccerStuff;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        audioSource = GetComponent<AudioSource>();
        audioSourceBounce = GetComponent<AudioSource>();

        waitText.enabled = false;

        throwAllowed = true;

        if (soccerLevel == true)
        {
            golfStuff.SetActive(false);
            soccerStuff.SetActive(true);
        }
        if (golfLevel == true)
        {
            soccerStuff.SetActive(false);
            golfStuff.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            touchTimeStart = Time.time;
            startPos = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0) && throwAllowed == true)
        {
            rb.gravityScale = 1.0f; // reset gravity

            touchTimeFinish = Time.time;

            timeInterval = touchTimeFinish - touchTimeStart;

            endPos = Input.mousePosition;

            direction = startPos - endPos;

            rb.isKinematic = false;
            rb.AddForce(-direction / timeInterval * throwForce);

            // Play Audio Here of ball hit
            if(golfLevel == true)
            {
                audioSource.Play();
            }

            if (soccerLevel == true)
            {
                audioSource.PlayOneShot(soccerHit);
            }
            

            StrokeManager.strokesNumber++;
            SoccerManager.enemyGoals++;

            throwAllowed = false;
        }

        if (throwAllowed == true)
        {
            previousSpot = transform.position;

            readyText.enabled = true;
            waitText.enabled = false;
        }
        else
        {
            readyText.enabled = false;
            waitText.enabled = true;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ( collision.gameObject.tag == "Ground")
        {
            // play bounce audio here
            audioSource.PlayOneShot(ballBounce);
        }

        if (collision.gameObject.tag == "Bounce")
        {
            audioSource.PlayOneShot(bouncy);
        }

        if(collision.gameObject.tag == "BallReset")
        {
            Debug.Log("hit Reset Zone");

            transform.position = previousSpot;

            audioSource.PlayOneShot(whistle, whistleVolume);

            rb.velocity = new Vector2(0, 0);                                                  // Freeze the ball
            rb.gravityScale = 0.0f;
            rb.freezeRotation = true;

            transform.position = previousSpot;
        }

        if (collision.gameObject.tag == "SoccerWin")
        {
            audioSource.PlayOneShot(soccerWin);
        }
    }

}
