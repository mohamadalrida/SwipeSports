using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RNG : MonoBehaviour {

    private int chance;

    public int percentage;

    public GameObject coin;

	// Use this for initialization
	void Start ()
    {
        chance = Random.Range(0, 100);

        Debug.Log("RNG" + chance);

        if (chance >= percentage)
        {
            Instantiate(coin);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
