using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipper : MonoBehaviour {

    public static string Equip;

    public GameObject Yellow;
    public GameObject Green;
    public GameObject Blue;
    public GameObject Sky;
    public GameObject Pink;
    public GameObject Red;

    // Use this for initialization
    void Start () { 

        Equip = PlayerPrefs.GetString("Equip", Equip);
        
    }
	
	// Update is called once per frame
	void Update () {

        Equip = PlayerPrefs.GetString("Equip", Equip);

        if (Equip == "Yellow")
        {
            Yellow.SetActive(true);
            Debug.Log("y");

            Green.SetActive(false);
            Blue.SetActive(false);
            Sky.SetActive(false);
            Pink.SetActive(false);
            Red.SetActive(false);
        }

        if (Equip == "Green")
        {
            Green.SetActive(true);

            Yellow.SetActive(false);
            Blue.SetActive(false);
            Sky.SetActive(false);
            Pink.SetActive(false);
            Red.SetActive(false);
        }

        if (Equip == "Blue")
        {
            Blue.SetActive(true);

            Yellow.SetActive(false);
            Green.SetActive(false);
            Sky.SetActive(false);
            Pink.SetActive(false);
            Red.SetActive(false);
        }

        if (Equip == "Sky")
        {
            Sky.SetActive(true);

            Yellow.SetActive(false);
            Green.SetActive(false);
            Blue.SetActive(false);
            Pink.SetActive(false);
            Red.SetActive(false);
        }

        if (Equip == "Pink")
        {
            Pink.SetActive(true);

            Yellow.SetActive(false);
            Green.SetActive(false);
            Blue.SetActive(false);
            Sky.SetActive(false);
            Red.SetActive(false);
        }

        if (Equip == "Red")
        {
            Red.SetActive(true);

            Yellow.SetActive(false);
            Green.SetActive(false);
            Blue.SetActive(false);
            Sky.SetActive(false);
            Pink.SetActive(false);
        }

    }
}
