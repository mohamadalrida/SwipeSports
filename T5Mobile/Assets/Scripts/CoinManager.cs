using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour {

    public static int Coins;
    public Text coinText;

    // Use this for initialization
    void Start () {

        Coins = PlayerPrefs.GetInt("Coins", Coins);

	}
	
	// Update is called once per frame
	void Update () {

        coinText.text = "Coins: " + Coins;

    }

    private void OnTriggerEnter2D()
    {
        Coins++;
        
        PlayerPrefs.SetInt("Coins", Coins);
        Debug.Log("< color = red > +1! Current Coins: " + Coins);
    }
}
