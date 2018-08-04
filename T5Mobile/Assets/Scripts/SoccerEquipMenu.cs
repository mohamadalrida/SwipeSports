using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoccerEquipMenu : MonoBehaviour {

    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;
    public Button btn5;
    public Button btn6;
    public Button btnAD;
    public Button btnRegular;

    private string Yellow = "Yellow";
    private string Green = "Green";
    private string Blue = "Blue";
    private string Sky = "Sky";
    private string Pink = "Pink";
    private string Red = "Red";
    private string AD = "AD";
    private string Regular = "Regular";

    // Use this for initialization
    void Start () {

        SoccerShop.SPurchased1 = PlayerPrefs.GetInt("SPurchased1", SoccerShop.SPurchased1);
        SoccerShop.SPurchased2 = PlayerPrefs.GetInt("SPurchased2", SoccerShop.SPurchased2);
        SoccerShop.SPurchased3 = PlayerPrefs.GetInt("SPurchased3", SoccerShop.SPurchased3);
        SoccerShop.SPurchased4 = PlayerPrefs.GetInt("SPurchased4", SoccerShop.SPurchased4);
        SoccerShop.SPurchased5 = PlayerPrefs.GetInt("SPurchased5", SoccerShop.SPurchased5);
        SoccerShop.SPurchased6 = PlayerPrefs.GetInt("SPurchased6", SoccerShop.SPurchased6);
        SoccerShop.SPurchasedAD = PlayerPrefs.GetInt("SPurchasedAD", SoccerShop.SPurchasedAD);

        Debug.Log("" + Shop.Purchased1);

    }
	
	// Update is called once per frame
	void Update () {

        Debug.Log("Purchase Green = " + SoccerShop.SPurchased3);

        if (SoccerShop.SPurchased1 == 1)
        {
            btn1.interactable = true;
        }


        if (SoccerShop.SPurchased2 == 1)
        {
            btn2.interactable = true;
        }


        if (SoccerShop.SPurchased3 == 1)
        {
            btn3.interactable = true;
        }


        if (SoccerShop.SPurchased4 == 1)
        {
            btn4.interactable = true;
        }


        if (SoccerShop.SPurchased5 == 1)
        {
            btn5.interactable = true;
        }


        if (SoccerShop.SPurchased6 == 1)
        {
            btn6.interactable = true;
        }

        if (SoccerShop.SPurchasedAD == 1)
        {
            btnAD.interactable = true;
        }

    }

    public void EquipYellow()
    {
        if (SoccerShop.SPurchased1 == 1)
        {
            PlayerPrefs.SetString("SEquip", Yellow);
            Debug.Log("equipped yellow");
        }
        else
        {
            btn1.interactable = false;
        }
    }

    public void EquipGreen()
    {
        if (SoccerShop.SPurchased2 == 1)
        {
            PlayerPrefs.SetString("SEquip", Green);
            Debug.Log("equipped green");
        }
        else
        {
            btn2.interactable = false;
        }
    }

    public void EquipBlue()
    {
        if (SoccerShop.SPurchased3 == 1)
        {
            PlayerPrefs.SetString("SEquip", Blue);
            Debug.Log("equipped blue");
        }
        else
        {
            btn3.interactable = false;
        }
    }

    public void EquipSky()
    {
        if (SoccerShop.SPurchased4 == 1)
        {
            PlayerPrefs.SetString("SEquip", Sky);
            Debug.Log("equipped sky");
        }
        else
        {
            btn4.interactable = false;
        }
    }

    public void EquipPink()
    {
        if (SoccerShop.SPurchased5 == 1)
        {
            PlayerPrefs.SetString("SEquip", Pink);
            Debug.Log("equipped pink");
        }
        else
        {
            btn5.interactable = false;
        }
    }

    public void EquipRed()
    {
        if (SoccerShop.SPurchased6 == 1)
        {
            PlayerPrefs.SetString("SEquip", Red);
            Debug.Log("equipped red");
        }
        else
        {
            btn6.interactable = false;
        }
    }

    public void EquipAD()
    {
        if (SoccerShop.SPurchasedAD == 1)
        {
            PlayerPrefs.SetString("SEquip", AD);
            Debug.Log("equipped ad");
        }
        else
        {
            btn6.interactable = false;
        }
    }

    public void EquipRegular()
    {
        PlayerPrefs.SetString("SEquip", Regular);
    }

}
