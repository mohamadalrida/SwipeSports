using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StrokeManager : MonoBehaviour {

    public Text strokes;
    public Text par;
    public Text hole;
    private int strokesNumber = 0;
    public int parNumber;
    public int holeNumber;


	// Use this for initialization
	void Start () {

        strokes.text = "" + strokesNumber;
        par.text = "" + parNumber;
        hole.text = "" + holeNumber;

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            strokesNumber++;
            strokes.text = "" + strokesNumber;
        }

	}
}
