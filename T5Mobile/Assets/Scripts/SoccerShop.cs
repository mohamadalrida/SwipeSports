using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoccerShop : MonoBehaviour {

    public int Cost1;
    public int Cost2;
    public int Cost3;
    public int Cost4;
    public int Cost5;
    public int Cost6;
    public int CostAD;

    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;
    public Button btn5;
    public Button btn6;
    public Button btnAD;

    public static int SPurchased1;
    public static int SPurchased2;
    public static int SPurchased3;
    public static int SPurchased4;
    public static int SPurchased5;
    public static int SPurchased6;
    public static int SPurchasedAD;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        SPurchased1 = PlayerPrefs.GetInt("SPurchased1", SPurchased1);
        SPurchased2 = PlayerPrefs.GetInt("SPurchased2", SPurchased2);
        SPurchased3 = PlayerPrefs.GetInt("SPurchased3", SPurchased3);
        SPurchased4 = PlayerPrefs.GetInt("SPurchased4", SPurchased4);
        SPurchased5 = PlayerPrefs.GetInt("SPurchased5", SPurchased5);
        SPurchased6 = PlayerPrefs.GetInt("SPurchased6", SPurchased6);
        SPurchasedAD = PlayerPrefs.GetInt("SPurchasedAD", SPurchasedAD);

        if (CoinManager.Coins < Cost1 || SPurchased1 == 1)
        {
            btn1.interactable = false;
        }

        if (CoinManager.Coins < Cost2 || SPurchased2 == 1)
        {
            btn2.interactable = false;
        }

        if (CoinManager.Coins < Cost3 || SPurchased3 == 1)
        {
            btn3.interactable = false;
        }

        if (CoinManager.Coins < Cost4 || SPurchased4 == 1)
        {
            btn4.interactable = false;
        }

        if (CoinManager.Coins < Cost5 || SPurchased5 == 1)
        {
            btn5.interactable = false;
        }
        if (CoinManager.Coins < Cost6 || SPurchased6 == 1)
        {
            btn6.interactable = false;
        }
        if (ADMoney.AdMoney < CostAD || SPurchasedAD == 1)
        {
            btnAD.interactable = false;
        }
    }

    public void Purchase1()
    {
        if (CoinManager.Coins >= Cost1)
        {
            CoinManager.Coins -= Cost1;
            PlayerPrefs.SetInt("Coins", CoinManager.Coins);

            SPurchased1 = 1;
            PlayerPrefs.SetInt("Purchased1", SPurchased1);


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

            SPurchased2 = 1;
            PlayerPrefs.SetInt("Purchased2", SPurchased2);

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

            SPurchased3 = 1;
            PlayerPrefs.SetInt("Purchased3", SPurchased3);
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

            SPurchased4 = 1;
            PlayerPrefs.SetInt("Purchased4", SPurchased4);
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

            SPurchased5 = 1;
            PlayerPrefs.SetInt("Purchased5", SPurchased5);
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

            SPurchased6 = 1;
            PlayerPrefs.SetInt("Purchased6", SPurchased6);
        }
    }

    public void PurchaseAD()
    {
        if (ADMoney.AdMoney >= CostAD)
        {
            Debug.Log("purchasing");
            
            ADMoney.AdMoney -= CostAD;
            PlayerPrefs.SetInt("AdMoney", ADMoney.AdMoney);

            Debug.Log("purchased");

            SPurchasedAD = 1;
            PlayerPrefs.SetInt("SPurchasedAD", SPurchasedAD);
        }
    }

}
