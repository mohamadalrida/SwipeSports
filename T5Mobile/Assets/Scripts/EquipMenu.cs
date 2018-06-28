using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipMenu : MonoBehaviour {
    
    private void Start()
    {
        Shop.Purchased1 = PlayerPrefs.GetInt("Purchased1", Shop.Purchased1);
        Shop.Purchased2 = PlayerPrefs.GetInt("Purchased2", Shop.Purchased2);
        Shop.Purchased3 = PlayerPrefs.GetInt("Purchased3", Shop.Purchased3);
        Shop.Purchased4 = PlayerPrefs.GetInt("Purchased4", Shop.Purchased4);
        Shop.Purchased5 = PlayerPrefs.GetInt("Purchased5", Shop.Purchased5);
        Shop.Purchased6 = PlayerPrefs.GetInt("Purchased6", Shop.Purchased6);
    }

    public void EquipYellow()
    {
        if (Shop.Purchased1 == 1)
        {
            PlayerPrefs.SetString("Equip", "Yellow");
            Debug.Log("equipped yellow");
        }
    }

    public void EquipGreen()
    {
        if (Shop.Purchased2 == 1)
        {
            PlayerPrefs.SetString("Equip", "Green");        
        } 
    }

    public void EquipBlue()
    {
        if (Shop.Purchased1 == 1)
        { 
            PlayerPrefs.SetString("Equip", "Blue");
        }
    }

    public void EquipSky()
    {
        if (Shop.Purchased1 == 1)
        {
            PlayerPrefs.SetString("Equip", "Sky");
        }
    }

    public void EquipPink()
    {
        if (Shop.Purchased1 == 1)
        {
            PlayerPrefs.SetString("Equip", "Pink");
        }
    }

    public void EquipRed()
    {
        if (Shop.Purchased1 == 1)
        {
            PlayerPrefs.SetString("Equip", "Red");
        }
    }
}
