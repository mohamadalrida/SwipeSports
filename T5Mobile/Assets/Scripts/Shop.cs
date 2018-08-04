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
    public int CostAD;

    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;
    public Button btn5;
    public Button btn6;
    public Button btnAD;

    public static int Purchased1;
    public static int Purchased2;
    public static int Purchased3;
    public static int Purchased4;
    public static int Purchased5;
    public static int Purchased6;
    public static int PurchasedAD;

    public GameObject nextShopSB;
    public GameObject nextShopGB;
    public GameObject shopGB;
    public GameObject shopSB;

    private void Update()
    {
        Purchased1 = PlayerPrefs.GetInt("Purchased1", Purchased1);
        Purchased2 = PlayerPrefs.GetInt("Purchased2", Purchased2);
        Purchased3 = PlayerPrefs.GetInt("Purchased3", Purchased3);
        Purchased4 = PlayerPrefs.GetInt("Purchased4", Purchased4);
        Purchased5 = PlayerPrefs.GetInt("Purchased5", Purchased5);
        Purchased6 = PlayerPrefs.GetInt("Purchased6", Purchased6);
        PurchasedAD = PlayerPrefs.GetInt("PurchasedAD", PurchasedAD);

        if (CoinManager.Coins < Cost1 || Purchased1 == 1)
        {
            btn1.interactable = false;
        }
        //else if (CoinManager.Coins >= Cost1)
        //{
        ////    btn1.interactable = true;
        //}

        if (CoinManager.Coins < Cost2 || Purchased2 == 1)
        {
            btn2.interactable = false;
        }

        if (CoinManager.Coins < Cost3 || Purchased3 == 1)
        {
            btn3.interactable = false;
        }

        if (CoinManager.Coins < Cost4 || Purchased4 == 1)
        {
            btn4.interactable = false;
        }

        if (CoinManager.Coins < Cost5 || Purchased5 == 1)
        {
            btn5.interactable = false;
        }
        if (CoinManager.Coins < Cost6 || Purchased6 == 1)
        {
            btn6.interactable = false;
        }
        if(ADMoney.AdMoney < CostAD || PurchasedAD == 1)
        {
            btnAD.interactable = false;
        }

    }

    public void NextShopSB()
    {
        nextShopSB.SetActive(false);
        nextShopGB.SetActive(true);
        shopGB.SetActive(false);
        shopSB.SetActive(true);
        
    }

    public void NextShopGB()
    {
        nextShopSB.SetActive(true);
        nextShopGB.SetActive(false);
        shopGB.SetActive(true);
        shopSB.SetActive(false);
        
    }

    public void Purchase1()
    {
        if (CoinManager.Coins >= Cost1)
        {
            CoinManager.Coins -= Cost1;
            PlayerPrefs.SetInt("Coins", CoinManager.Coins);

            Purchased1 = 1;
            PlayerPrefs.SetInt("Purchased1", Purchased1);

            
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

            Purchased2 = 1;
            PlayerPrefs.SetInt("Purchased2", Purchased2);

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

            Purchased3= 1;
            PlayerPrefs.SetInt("Purchased3", Purchased3);
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

            Purchased4= 1;
            PlayerPrefs.SetInt("Purchased4", Purchased4);
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

            Purchased5 = 1;
            PlayerPrefs.SetInt("Purchased5", Purchased5);
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

            Purchased6 = 1;
            PlayerPrefs.SetInt("Purchased6", Purchased6);
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

            PurchasedAD = 1;
            PlayerPrefs.SetInt("PurchasedAD", PurchasedAD);
        }
    }

}
