using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipMenu : MonoBehaviour {

   

    private void Start()
    {
       
    }

    public void EquipYellow()
    {
        PlayerPrefs.SetString("Equip", "Yellow");
        Debug.Log("equipped yellow");
    }

    public void EquipGreen()
    {
        PlayerPrefs.SetString("Equip", "Green");
    }

    public void EquipBlue()
    {
        PlayerPrefs.SetString("Equip", "Blue");
    }

    public void EquipSky()
    {
        PlayerPrefs.SetString("Equip", "Sky");
    }

    public void EquipPink()
    {
        PlayerPrefs.SetString("Equip", "Pink");
    }

    public void EquipRed()
    {
        PlayerPrefs.SetString("Equip", "Red");
    }
   
}
