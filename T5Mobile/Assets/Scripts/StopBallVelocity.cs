using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopBallVelocity : MonoBehaviour {

    private Rigidbody2D rb;

    private Vector2 currentBallSpeed;
    private Vector2 newPosition;


    private bool thrown;

    private float waitTime ;
    public float waitAfterHit;

    public float ballStopSpeedpos;
    public float ballStopSpeedneg;

    private float timeBetweenDirection;
    public float timeBallStopped;

    
      


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

        //Debug.Log("current velocity = " + rb.velocity);

        
        thrown = GetComponent<DragThrow>().throwAllowed;

        //Debug.Log("Wait Seconds : " + waitTime);

        //Debug.Log("Time Between Direction : " + timeBetweenDirection);

        if (Input.GetKeyDown("space"))                       // when space pressed stop the ball
        {
            //Debug.Log("Stopping Speed Reached ");

            rb.velocity = new Vector2(0, 0);
            rb.gravityScale = 0.0f;
            rb.freezeRotation = true;

            //Debug.Log("Ball Stopped ");
        }

        if (Input.GetKeyDown("x"))                           // When X pressed allow next stroke
        {
            
            rb.velocity = new Vector2(0, 0);
            rb.gravityScale = 1.0f;
            rb.freezeRotation = false;

            thrown = true;
            waitTime = 0;

            GetComponent<DragThrow>().throwAllowed = true;
            
        }

        if (thrown == false)           // When the ball is thrown
        {
            //Debug.Log("------Ball Hit-------");

            if (waitTime <= waitAfterHit)        // Start count down clock
            {
                waitTime += Time.deltaTime;
            }

            if (waitTime >= waitAfterHit)        // If the clock has reached passed X seconds
            {
                           
                if (currentBallSpeed.x < ballStopSpeedpos && currentBallSpeed.x > ballStopSpeedneg)       // If the ball is between a certain velocity in either direction
                {

                    if (currentBallSpeed.y < ballStopSpeedpos && currentBallSpeed.y > ballStopSpeedneg)
                    {
                        timeBetweenDirection += Time.deltaTime;                                               // Start second timer that tracks when the ball is slow enough, so collisions with wall wont stop the ball

                        if (timeBetweenDirection >= timeBallStopped)                                                        // If the ball is slow enough for X amount of secoonds 
                        {

                    

                            Debug.Log("Stopping Speed Reached ");

                            rb.velocity = new Vector2(0, 0);                                                  // Freeze the ball
                            rb.gravityScale = 0.0f;
                            rb.freezeRotation = true;

                            Debug.Log("Ball Stopped ");

                            if (rb.freezeRotation == true)                                                    // Add Stroke
                            {
                                //StrokeManager.strokesNumber++;
                            }

                            waitTime = 0;                                                                     // Reset waitTime

                            if (waitTime == 0)                                                                // If wait has been reset, reset ball settings
                            {   
                                rb.velocity = new Vector2(0, 0);
                                //rb.gravityScale = 1.0f;          // Disabling to reset on release of swipe
                                rb.freezeRotation = false;

                                thrown = true;
                            
                                GetComponent<DragThrow>().throwAllowed = true;                                // Allow next stoke to be taken

                                timeBetweenDirection = 0;                                                     // Reset ball slowed timer

                            
                            }
                    }
                        
                    }

                }
                
            }
        }


    }
}
