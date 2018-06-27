using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour {

    public int Cost1;
    public int Cost2;
    public int Cost3;
    public int Cost4;
    public int Cost5;
    public int Cost6;
    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;
    public Button btn5;
    public Button btn6;

    private void Update()
    {
        if (CoinManager.Coins < Cost1)
        {
            btn1.interactable = false;
        }

        if (CoinManager.Coins < Cost2)
        {
            btn2.interactable = false;
        }

        if (CoinManager.Coins < Cost3)
        {
            btn3.interactable = false;
        }

        if (CoinManager.Coins < Cost4)
        {
            btn4.interactable = false;
        }

        if (CoinManager.Coins < Cost5)
        {
            btn5.interactable = false;
        }
        if (CoinManager.Coins < Cost6)
        {
            btn6.interactable = false;
        }



    }

    public void Purchase1()
    {
        if (CoinManager.Coins >= Cost1)
        {
            Debug.Log("purchasing");
            CoinManager.Coins -= Cost1;
            PlayerPrefs.SetInt("Coins", CoinManager.Coins);
            Debug.Log("purchased");
        }
        
    }

    public void Purchase2()
    {
        if (CoinManager.Coins >= Cost2)
        {

            Debug.Log("purchasing");
            CoinManager.Coins -= Cost2;
            PlayerPrefs.SetInt("Coins", CoinManager.Coins);
            Debug.Log("purchased");

        }
    }

    public void Purchase3()
    {
        if (CoinManager.Coins >= Cost3)
        {
            Debug.Log("purchasing");
            CoinManager.Coins -= Cost3;
            PlayerPrefs.SetInt("Coins", CoinManager.Coins);
            Debug.Log("purchased");
        }
    }

    public void Purchase4()
    {
        if (CoinManager.Coins >= Cost4)
        {
            Debug.Log("purchasing");
            CoinManager.Coins -= Cost4;
            PlayerPrefs.SetInt("Coins", CoinManager.Coins);
            Debug.Log("purchased");
        }
    }

    public void Purchase5()
    {
        if (CoinManager.Coins >= Cost5)
        {
            Debug.Log("purchasing");
            CoinManager.Coins -= Cost5;
            PlayerPrefs.SetInt("Coins", CoinManager.Coins);
            Debug.Log("purchased");
        }
    }

    public void Purchase6()
    {
        if (CoinManager.Coins >= Cost6)
        {
            Debug.Log("purchasing");
            CoinManager.Coins -= Cost6;
            PlayerPrefs.SetInt("Coins", CoinManager.Coins);
            Debug.Log("purchased");
        }
    }

}
