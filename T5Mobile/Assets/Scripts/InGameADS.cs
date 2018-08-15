using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using TMPro;
using UnityEngine.SceneManagement;

public class InGameADS : MonoBehaviour {

    public bool android;
    public bool ios;

    public GameObject panel;
    public TextMeshProUGUI moneyEarned;

    // Use this for initialization
    void Start () {

        if (android == true)
        {
            Advertisement.Initialize("2726910");
        }

        if (ios == true)
        {
            Advertisement.Initialize("2726909");
        }

    }

    public void ShowAd()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show("", new ShowOptions() { resultCallback = HandleAdResult });
        }
    }

    public void HandleAdResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                int x = Random.Range(2, 4);
                ADMoney.AdMoney += x;
                PlayerPrefs.SetInt("AdMoney", ADMoney.AdMoney);

                panel.SetActive(true);
                moneyEarned.fontSize = 64;
                moneyEarned.text = "Thanks for watching the Ad! You've earned " + x + " AD coins! We appreciate you watching the Ad fully.";

                break;
            case ShowResult.Skipped:
                ADMoney.AdMoney++;
                Debug.Log("Player skipped ad");

                panel.SetActive(true);
                moneyEarned.fontSize = 62; ;
                moneyEarned.text = "Thanks for watching the Ad! You've earned 1 AD coin, although you could get more if you watch the full Ad.";
                break;
            case ShowResult.Failed:

                panel.SetActive(true);
                moneyEarned.fontSize = 64;
                moneyEarned.text = "AD failed to load. Please check that you are connected to the internet and try again.";
                Debug.Log("Player failed to load ad");
                break;
        }
    }

    public void Continue()
    {
        panel.SetActive(false);
        SceneManager.LoadScene("MainMenuSwipeSports");
    }
}
