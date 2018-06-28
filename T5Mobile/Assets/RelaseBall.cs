using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelaseBall : MonoBehaviour {

    public GameObject theBall1;

    private Rigidbody2D rb;

    public float releaseSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    private void OnTriggerStay2D(Collider2D theBall1)
    {
        Debug.Log("Release!!!");

        theBall1.transform.parent = transform;

        rb = theBall1.GetComponent<Rigidbody2D>();

        theBall1.attachedRigidbody.AddForce(transform.forward * releaseSpeed);
    }
}
