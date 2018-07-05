using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuResetter : MonoBehaviour {

	// Use this for initialization
	void Start () {

        WinLevel.Strokes1 = 0;
        WinLevel.Strokes2 = 0;
        WinLevel.Strokes3 = 0;
        WinLevel.Strokes4 = 0;
        WinLevel.Strokes5 = 0;
        WinLevel.Strokes6 = 0;
        WinLevel.Strokes7 = 0;
        WinLevel.Strokes8 = 0;
        WinLevel.Strokes9 = 0;
        
    }

    // Update is called once per frame
    void Update () {
		
	}
}
