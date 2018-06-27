using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipper : MonoBehaviour {

    public static string Equip;

	// Use this for initialization
	void Start () {
		
        Equip = PlayerPrefs.GetString("Equip", Equip);

    }
	
	// Update is called once per frame
	void Update () {


	}
}
