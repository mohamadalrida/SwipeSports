using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopBallVelocity : MonoBehaviour {

    public Rigidbody2D rb;

    public Vector2 stopSpeed;
    private Vector2 currentBallSpeed;
    private Vector2 newPosition;

    

    


	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();

        currentBallSpeed = rb.velocity;

        
        //stopSpeed = new Vector2((-1f, 1f), (-100f, 100f));

    }
	
	// Update is called once per frame
	void Update ()
    {
        currentBallSpeed = rb.velocity;

        Debug.Log("current velocity = " + rb.velocity);

        if (Input.GetKeyDown("space"))
        {
            Debug.Log("Stopping Speed Reached ");

            rb.velocity = new Vector2(0, 0);

            Debug.Log("Ball Stopped ");
        }

        
        if ( currentBallSpeed.x > 1)
        {
            
            Debug.Log("Stopping Speed Reached ");

            currentBallSpeed = new Vector2(0, 0);

            Debug.Log("Ball Stopped ");

        }

	}
}
