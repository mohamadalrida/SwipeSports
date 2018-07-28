using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SoccerManager : MonoBehaviour {

    public static int enemyGoals;
    public static int yourGoals;

    public TextMeshProUGUI hits;
    public TextMeshProUGUI par;
    public TextMeshProUGUI hole;

    public int parNumber;
    public int holeNumber;

	// Use this for initialization
	void Start () {

        yourGoals = 0;
        enemyGoals = 0;
        hits.text = "" + enemyGoals;
        par.text = "" + parNumber;
        hole.text = "" + holeNumber;
	}
	
	// Update is called once per frame
	void Update () {

        hits.text = "" + enemyGoals;
        par.text = "" + (parNumber + yourGoals);
	}
}
