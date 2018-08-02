using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer : MonoBehaviour {

    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Input.acceleration.x, Input.acceleration.y, 0);

        //transform.position = new Vector3(Mathf.Clamp(Time.time, xMin, xMax), (Mathf.Clamp(Time.time, yMin, yMax)), 0);
    }
}
