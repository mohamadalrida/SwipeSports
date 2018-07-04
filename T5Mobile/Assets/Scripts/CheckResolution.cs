using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckResolution : MonoBehaviour {

    public static string BetterThan169;

    public TextMeshProUGUI resolution;

	// Use this for initialization
	void Start () {

        resolution.text = ("" + Screen.currentResolution);

        if (Screen.currentResolution.height >= 1440 && Screen.currentResolution.width > 2560)
        {
            BetterThan169 = "BetterThan169";
            Debug.Log ("This IS better than 16:9");
            Debug.Log("" + BetterThan169);
        }
        else
        {
            BetterThan169 = "NOTBetterThan169";
            Debug.Log("This ISN'T better than 16:9");
            Debug.Log("" + BetterThan169);
        }
        
    }
	
	
}
