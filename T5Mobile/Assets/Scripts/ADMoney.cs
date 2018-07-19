using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class ADMoney : MonoBehaviour {

    public static int AdMoney;

	// Use this for initialization
	void Start () {
        AdMoney = PlayerPrefs.GetInt("AdMoney",AdMoney);
	}
	
	//public void ShowAd()
    //{
    //    if (//Advertisement.IsReady())
    //    {
    //        //Advertisement.Show();
    //    }
    //}
}
//2685945