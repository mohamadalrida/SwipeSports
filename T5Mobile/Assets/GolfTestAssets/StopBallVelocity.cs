using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopBallVelocity : MonoBehaviour {

    public Rigidbody2D rb;

    public Vector2 stopSpeed;
    private Vector2 currentBallSpeed;
    private Vector2 newPosition;


    private bool thrown;

    

    


	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();

        currentBallSpeed = rb.velocity;

        thrown = GetComponent<DragThrow>().throwAllowed;

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


        //if (thrown == true)
        //{
        //    if ( currentBallSpeed.x > 1)
        //    {
            
        //    Debug.Log("Stopping Speed Reached ");

        //    rb.velocity = new Vector2(0, 0);

        //    Debug.Log("Ball Stopped ");

        //    }

        //}
        

	}
}
