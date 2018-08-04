using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipMenu : MonoBehaviour {

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

    public GameObject nextEquipSB;
    public GameObject nextEquipGB;
    public GameObject equipSB;
    public GameObject equipGB;
    public GameObject golfBall;
    public GameObject soccerBall;

    private void Start()
    {
        Shop.Purchased1 = PlayerPrefs.GetInt("Purchased1", Shop.Purchased1);
        Shop.Purchased2 = PlayerPrefs.GetInt("Purchased2", Shop.Purchased2);
        Shop.Purchased3 = PlayerPrefs.GetInt("Purchased3", Shop.Purchased3);
        Shop.Purchased4 = PlayerPrefs.GetInt("Purchased4", Shop.Purchased4);
        Shop.Purchased5 = PlayerPrefs.GetInt("Purchased5", Shop.Purchased5);
        Shop.Purchased6 = PlayerPrefs.GetInt("Purchased6", Shop.Purchased6);
        Shop.PurchasedAD = PlayerPrefs.GetInt("PurchasedAD", Shop.PurchasedAD);

        Debug.Log("" + Shop.Purchased1);
    }

    private void Update()
    {
        if (Shop.Purchased1 == 1)
        {
            btn1.interactable = true;
        }
        

        if (Shop.Purchased2 == 1)
        {
            btn2.interactable = true;
        }
        

        if (Shop.Purchased3 == 1)
        {
            btn3.interactable = true;
        }
        

        if (Shop.Purchased4 == 1)
        {
            btn4.interactable = true;
        }
        

        if (Shop.Purchased5 == 1)
        {
            btn5.interactable = true;
        }
        

        if (Shop.Purchased6 == 1)
        {
            btn6.interactable = true;
        }

        if (Shop.PurchasedAD == 1)
        {
            btnAD.interactable = true;
        }
        
    }

    public void NextShopSB()
    {
        nextEquipSB.SetActive(false);
        nextEquipGB.SetActive(true);
        equipGB.SetActive(false);
        equipSB.SetActive(true);
        soccerBall.SetActive(true);
        golfBall.SetActive(false);
    }

    public void NextShopGB()
    {
        nextEquipSB.SetActive(true);
        nextEquipGB.SetActive(false);
        equipGB.SetActive(true);
        equipSB.SetActive(false);
        soccerBall.SetActive(false);
        golfBall.SetActive(true);
    }

    public void EquipYellow()
    {
        if (Shop.Purchased1 == 1)
        {
            PlayerPrefs.SetString("Equip", Yellow);
            Debug.Log("equipped yellow");
        }
        else
        {
            btn1.interactable = false;
        }
    }

    public void EquipGreen()
    {
        if (Shop.Purchased2 == 1)
        {
            PlayerPrefs.SetString("Equip", Green);        
        }
        else
        {
            btn2.interactable = false;
        }
    }

    public void EquipBlue()
    {
        if (Shop.Purchased3 == 1)
        { 
            PlayerPrefs.SetString("Equip", Blue);
        }
        else
        {
            btn3.interactable = false;
        }
    }

    public void EquipSky()
    {
        if (Shop.Purchased4 == 1)
        {
            PlayerPrefs.SetString("Equip", Sky);
        }
        else
        {
            btn4.interactable = false;
        }
    }

    public void EquipPink()
    {
        if (Shop.Purchased5 == 1)
        {
            PlayerPrefs.SetString("Equip", Pink);
        }
        else
        {
            btn5.interactable = false;
        }
    }

    public void EquipRed()
    {
        if (Shop.Purchased6 == 1)
        {
            PlayerPrefs.SetString("Equip", Red);
        }
        else
        {
            btn6.interactable = false;
        }
    }

    public void EquipAD()
    {
        if (Shop.PurchasedAD == 1)
        {
            PlayerPrefs.SetString("Equip", AD);
        }
        else
        {
            btn6.interactable = false;
        }
    }

    public void EquipRegular()
    {
        PlayerPrefs.SetString("Equip", Regular);
    }


}
