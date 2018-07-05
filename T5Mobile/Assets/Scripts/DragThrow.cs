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

    public AudioClip ballHit;
    public AudioClip ballBounce;
    private AudioSource audioSource;
    private AudioSource audioSourceBounce;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        audioSource = GetComponent<AudioSource>();
        audioSourceBounce = GetComponent<AudioSource>();

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

            // Play Audio Here of ball hit

            audioSource.Play();

            StrokeManager.strokesNumber++;

            throwAllowed = false;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ( collision.gameObject.tag == "Ground")
        {
            // play bounce audio here
        }
    }
}
