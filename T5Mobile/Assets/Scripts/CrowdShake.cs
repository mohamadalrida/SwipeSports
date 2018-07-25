using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowdShake : MonoBehaviour {

    public float shakeSpeed;
    public float shakeDistance;

    private Vector2 defaultPos;

    Rigidbody2D rb;

    public float gravityScale;


	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = defaultPos + Random.insideUnitCircle*shakeSpeed;

        rb.gravityScale = gravityScale;


    }
}
