using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer : MonoBehaviour {

    // Disable This If Doesnt Work
    // Disble This If Doesnt Work
    public Vector2 minPosition = new Vector2(-7,-4);
    public Vector2 maxPosition = new Vector2(7.5f, 4);
    // Disable This If Doesnt Work
    // Disable This If Doesnt Work


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

        transform.Translate(Input.acceleration.x, Input.acceleration.y, 0);


        // Disable This If Doesnt Work
        // Disable This If Doesnt Work
        // get position 
        Vector2 Pos = transform.position;

        // clamp the x coordinate of Pos 
        Pos.x = Mathf.Clamp(Pos.x, minPosition.x, maxPosition.x);
        Pos.y = Mathf.Clamp(Pos.y, minPosition.y, maxPosition.y);
        // Disable This If Doesnt Work
        // Disable This If Doesnt Work

        //transform.position = new Vector3(Mathf.Clamp(Time.time, xMin, xMax), (Mathf.Clamp(Time.time, yMin, yMax)), 0);
    }
}
