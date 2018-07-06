using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RNG : MonoBehaviour {

    public int chance;

    public int percentage;

    public GameObject coin;

    //public Transform coinPlace;


	// Use this for initialization
	void Start ()
    {
        coin.SetActive(false);

        chance = Random.Range(0, 100);

        Debug.Log("RNG" + chance);
            
        if (percentage >= chance)
        {
            coin.SetActive(true);
        }
        else if (percentage < chance)
        {
            coin.SetActive(false);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
