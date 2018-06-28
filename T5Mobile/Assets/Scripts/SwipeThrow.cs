using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeThrow : MonoBehaviour {

    Vector2 startPos;
    Vector2 endPos;
    Vector2 direction;

    float touchTimeStart;
    float touchTimeFinish;
    float timeInterval;

    Rigidbody2D rb;

    public bool throwAllowed = true;

    public float throwForce = 0.3f;


	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (throwAllowed == true)
        {


            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                touchTimeStart = Time.time;
                startPos = Input.GetTouch(0).position;
            }

            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended && throwAllowed)
            {
                rb.gravityScale = 1.0f; // reset gravity

                touchTimeFinish = Time.time;

                timeInterval = touchTimeFinish - touchTimeStart;

                endPos = Input.GetTouch(0).position;

                direction = startPos - endPos;

                rb.isKinematic = false;
                rb.AddForce(-direction / timeInterval * throwForce);

                throwAllowed = false;
            }
        }
    }
}
