using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using TMPro;

public class ADMoney : MonoBehaviour {

    public static int AdMoney;
    public TextMeshProUGUI adMoney;

    public bool android;
    public bool ios;


	// Use this for initialization
	void Start () {

        if (android == true)
        {
            Advertisement.Initialize("2685945");
        }

        if (ios == true)
        {
            Advertisement.Initialize("2685944");
        }
        //Advertisement.Initialize("2685945");

        AdMoney = PlayerPrefs.GetInt("AdMoney",AdMoney);
	}

    private void Update()
    {
        adMoney.text = ": " + AdMoney;
    }

    public void ShowAd()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show("rewardedVideo", new ShowOptions() { resultCallback = HandleAdResult });
        }
    }

    public void HandleAdResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                AdMoney++;
                PlayerPrefs.SetInt("AdMoney", AdMoney);
                break;
            case ShowResult.Skipped:
                Debug.Log("Player skipped ad");
                break;
            case ShowResult.Failed:
                Debug.Log("Player failed to load ad");
                break;
        }
    }
}
