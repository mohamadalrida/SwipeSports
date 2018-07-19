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

    private void Start()
    {
        Shop.Purchased1 = PlayerPrefs.GetInt("Purchased1", Shop.Purchased1);
        Shop.Purchased2 = PlayerPrefs.GetInt("Purchased2", Shop.Purchased2);
        Shop.Purchased3 = PlayerPrefs.GetInt("Purchased3", Shop.Purchased3);
        Shop.Purchased4 = PlayerPrefs.GetInt("Purchased4", Shop.Purchased4);
        Shop.Purchased5 = PlayerPrefs.GetInt("Purchased5", Shop.Purchased5);
        Shop.Purchased6 = PlayerPrefs.GetInt("Purchased6", Shop.Purchased6);

        Debug.Log("" + Shop.Purchased1);

        if (Shop.Purchased1 == 1)
        {
            btn1.enabled = true;
        }
        else
        {
            btn1.enabled = false;
        }

        if (Shop.Purchased2 == 1)
        {
            btn2.enabled = true;
        }
        else
        {
            btn2.enabled = false;
        }

        if (Shop.Purchased3 == 1)
        {
            btn3.enabled = true;
        }
        else
        {
            btn3.enabled = false;
        }

        if (Shop.Purchased4 == 1)
        {
            btn4.enabled = true;
        }
        else
        {
            btn4.enabled = false;
        }

        if (Shop.Purchased5 == 1)
        {
            btn5.enabled = true;
        }
        else
        {
            btn5.enabled = false;
        }

        if (Shop.Purchased6 == 1)
        {
            btn6.enabled = true;
        }
        else
        {
            btn6.enabled = false;
        }
    }

    public void EquipYellow()
    {
        if (Shop.Purchased1 == 1)
        {
            PlayerPrefs.SetString("Equip", "Yellow");
            Debug.Log("equipped yellow");
        }
        else
        {
            btn1.enabled = false;
        }
    }

    public void EquipGreen()
    {
        if (Shop.Purchased2 == 1)
        {
            PlayerPrefs.SetString("Equip", "Green");        
        }
        else
        {
            btn2.enabled = false;
        }
    }

    public void EquipBlue()
    {
        if (Shop.Purchased1 == 1)
        { 
            PlayerPrefs.SetString("Equip", "Blue");
        }
        else
        {
            btn3.enabled = false;
        }
    }

    public void EquipSky()
    {
        if (Shop.Purchased1 == 1)
        {
            PlayerPrefs.SetString("Equip", "Sky");
        }
        else
        {
            btn4.enabled = false;
        }
    }

    public void EquipPink()
    {
        if (Shop.Purchased1 == 1)
        {
            PlayerPrefs.SetString("Equip", "Pink");
        }
        else
        {
            btn5.enabled = false;
        }
    }

    public void EquipRed()
    {
        if (Shop.Purchased1 == 1)
        {
            PlayerPrefs.SetString("Equip", "Red");
        }
        else
        {
            btn6.enabled = false;
        }
    }
}
