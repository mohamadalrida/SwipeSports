using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerEquipper : MonoBehaviour {

    public static string SEquip;

    public GameObject Regular;
    public GameObject Yellow;
    public GameObject Green;
    public GameObject Blue;
    public GameObject Sky;
    public GameObject Pink;
    public GameObject Red;
    public GameObject AD;

    //public GameObject golfStuff;
    //public GameObject soccerStuff;

    // Use this for initialization
    void Start () {

        SEquip = PlayerPrefs.GetString("SEquip", SEquip);

        //if (DragThrow.soccerLevel == true)
        //{
        //    golfStuff.SetActive(false);
        //    soccerStuff.SetActive(true);
        //}
        //else
        //{
        //    soccerStuff.SetActive(false);
        //    golfStuff.SetActive(true);
        //}

	}
	
	// Update is called once per frame
	void Update () {

        SEquip = PlayerPrefs.GetString("SEquip", SEquip);

        if (SEquip == "Yellow")
        {
            Yellow.SetActive(true);
            Debug.Log("y");

            Green.SetActive(false);
            Blue.SetActive(false);
            Sky.SetActive(false);
            Pink.SetActive(false);
            Red.SetActive(false);
            AD.SetActive(false);
            Regular.SetActive(false);
        }

        if (SEquip == "Green")
        {
            Green.SetActive(true);

            Yellow.SetActive(false);
            Blue.SetActive(false);
            Sky.SetActive(false);
            Pink.SetActive(false);
            Red.SetActive(false);
            AD.SetActive(false);
            Regular.SetActive(false);
        }

        if (SEquip == "Blue")
        {
            Blue.SetActive(true);
            Debug.Log("blue");
            Yellow.SetActive(false);
            Green.SetActive(false);
            Sky.SetActive(false);
            Pink.SetActive(false);
            Red.SetActive(false);
            AD.SetActive(false);
            Regular.SetActive(false);
        }

        if (SEquip == "Sky")
        {
            Sky.SetActive(true);

            Yellow.SetActive(false);
            Green.SetActive(false);
            Blue.SetActive(false);
            Pink.SetActive(false);
            Red.SetActive(false);
            AD.SetActive(false);
            Regular.SetActive(false);
        }

        if (SEquip == "Pink")
        {
            Pink.SetActive(true);

            Yellow.SetActive(false);
            Green.SetActive(false);
            Blue.SetActive(false);
            Sky.SetActive(false);
            Red.SetActive(false);
            AD.SetActive(false);
            Regular.SetActive(false);
        }

        if (SEquip == "Red")
        {
            Red.SetActive(true);

            Yellow.SetActive(false);
            Green.SetActive(false);
            Blue.SetActive(false);
            Sky.SetActive(false);
            Pink.SetActive(false);
            AD.SetActive(false);
            Regular.SetActive(false);
        }

        if (SEquip == "AD")
        {
            AD.SetActive(true);

            Yellow.SetActive(false);
            Green.SetActive(false);
            Blue.SetActive(false);
            Sky.SetActive(false);
            Pink.SetActive(false);
            Red.SetActive(false);
            Regular.SetActive(false);
        }

        if (SEquip == "Regular")
        {
            Regular.SetActive(true);
            
            Yellow.SetActive(false);
            Green.SetActive(false);
            Blue.SetActive(false);
            Sky.SetActive(false);
            Pink.SetActive(false);
            Red.SetActive(false);
            AD.SetActive(false);
        }
    }
}
