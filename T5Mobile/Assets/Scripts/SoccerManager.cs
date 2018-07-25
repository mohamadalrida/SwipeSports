using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SoccerManager : MonoBehaviour {

    public static int hitsNumber;

    public TextMeshProUGUI hits;
    public TextMeshProUGUI par;
    public TextMeshProUGUI hole;

    public int parNumber;
    public int holeNumber;

	// Use this for initialization
	void Start () {

        hitsNumber = 0;
        hits.text = "" + hitsNumber;
        par.text = "" + parNumber;
        hole.text = "" + holeNumber;
	}
	
	// Update is called once per frame
	void Update () {

        hits.text = "" + hitsNumber;
	}
}
