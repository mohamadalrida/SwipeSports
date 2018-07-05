using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnMusicOn : MonoBehaviour {

    public GameObject backGroundMusic;

	// Use this for initialization
	void Start ()
    {
        backGroundMusic.SetActive(true);

        Destroy(this.gameObject);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
