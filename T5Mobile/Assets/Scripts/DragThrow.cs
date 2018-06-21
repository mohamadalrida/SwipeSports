using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            touchTimeStart = Time.time;
            startPos = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0) && throwAllowed)
        {
            rb.gravityScale = 1.0f; // reset gravity

            touchTimeFinish = Time.time;

            timeInterval = touchTimeFinish - touchTimeStart;

            endPos = Input.mousePosition;

            direction = startPos - endPos;

            rb.isKinematic = false;
            rb.AddForce(-direction / timeInterval * throwForce);

            //StrokeManager.strokesNumber++;

            throwAllowed = false;
        }

    }
}
