using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUpEquip : MonoBehaviour {

    public GameObject Yellow;
    public GameObject Green;
    public GameObject Blue;
    public GameObject Sky;
    public GameObject Pink;
    public GameObject Red;

    // Use this for initialization
    void Start () {

        Equipper.Equip = PlayerPrefs.GetString("Equip", Equipper.Equip);

        if (Equipper.Equip == "Yellow")
        {
            Yellow.SetActive(true);
        }

        if (Equipper.Equip == "Green")
        {
            Green.SetActive(true);
        }

        if (Equipper.Equip == "Blue")
        {
            Blue.SetActive(true);
        }

        if (Equipper.Equip == "Sky")
        {
            Sky.SetActive(true);
        }

        if (Equipper.Equip == "Pink")
        {
            Pink.SetActive(true);
        }

        if (Equipper.Equip == "Red")
        {
            Red.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
