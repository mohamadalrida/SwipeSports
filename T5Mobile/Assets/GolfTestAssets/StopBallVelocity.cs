using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopBallVelocity : MonoBehaviour {

    public Rigidbody2D rb;

    private Vector2 currentBallSpeed;
    private Vector2 newPosition;


    private bool thrown;

    public float waitTime ;

    public float ballStopSpeedpos;
    public float ballStopSpeedneg;

    
      


	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();

        currentBallSpeed = rb.velocity;

        
    }

    // Update is called once per frame
    void Update()
    {
        currentBallSpeed = rb.velocity;

        Debug.Log("current velocity = " + rb.velocity);

        
        thrown = GetComponent<DragThrow>().throwAllowed;

        Debug.Log("Wait Seconds : " + waitTime);

        if (Input.GetKeyDown("space"))
        {
            Debug.Log("Stopping Speed Reached ");

            rb.velocity = new Vector2(0, 0);
            rb.gravityScale = 0.0f;
            rb.freezeRotation = true;

            Debug.Log("Ball Stopped ");
        }

        if (Input.GetKeyDown("x"))
        {
            
            rb.velocity = new Vector2(0, 0);
            rb.gravityScale = 1.0f;
            rb.freezeRotation = false;

            thrown = true;
            waitTime = 0;

            GetComponent<DragThrow>().throwAllowed = true;
            
        }

        if (thrown == false)
        {
            Debug.Log("------Ball Hit-------");

            if (waitTime <= 5)
            {
                waitTime += Time.deltaTime;
            }

            if (waitTime >= 5)
            {
                           
                if (currentBallSpeed.x < ballStopSpeedpos && currentBallSpeed.x > ballStopSpeedneg)
                {

                    Debug.Log("Stopping Speed Reached ");

                    rb.velocity = new Vector2(0, 0);
                    rb.gravityScale = 0.0f;
                    rb.freezeRotation = true;

                    Debug.Log("Ball Stopped ");

                    if (rb.freezeRotation == true)
                    {
                        StrokeManager.strokesNumber++;
                    }

                    waitTime = 0;

                    if (waitTime == 0)
                    {
                        rb.velocity = new Vector2(0, 0);
                        rb.gravityScale = 1.0f;
                        rb.freezeRotation = false;

                        thrown = true;
                        
                        GetComponent<DragThrow>().throwAllowed = true;
                    }
                    
                }
            }
        }


    }
}
