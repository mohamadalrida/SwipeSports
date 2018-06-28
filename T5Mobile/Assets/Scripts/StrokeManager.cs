using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StrokeManager : MonoBehaviour {

    public static int strokesNumber;
    

    public TextMeshProUGUI strokess;
    public TextMeshProUGUI par;
    public TextMeshProUGUI hole;

    public int parNumber;
    public int holeNumber;

	// Use this for initialization
	void Start () {

        strokesNumber = 0;
        strokess.text = "" + strokesNumber;
        
        par.text = "" + parNumber;
        hole.text = "" + holeNumber;

    }
	
	// Update is called once per frame
	void Update () {

        strokess.text = "" + strokesNumber;

	}
}
