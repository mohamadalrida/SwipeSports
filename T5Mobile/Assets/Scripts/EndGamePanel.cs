using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class EndGamePanel : MonoBehaviour {

    public GameObject Pause;
    public GameObject UnPause;

    public TextMeshProUGUI levelNumber;
    public TextMeshProUGUI strokeNumber;
    public TextMeshProUGUI parNumber;

    public TextMeshProUGUI levelNo;
    public TextMeshProUGUI strokeNo;
    public TextMeshProUGUI parNo;

    public Canvas mainCanvas;
    public Canvas endCanvas;

    public GameObject mainMenuConfirmation;

    public string nextLevel;



	// Use this for initialization
	void Start () {

        Time.timeScale = 1;
        levelNo.text = "Completed Level: " + levelNumber.text;
        strokeNo.text = "in" + strokeNumber.text + "strokes.";
        parNo.text = "Par: " + parNumber.text;
        
        mainCanvas.enabled = false;
        endCanvas.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Continue()
    {
        SceneManager.LoadScene(nextLevel);
    }

    public void MenuConfirmation()
    {
        mainMenuConfirmation.SetActive(true);

        //SceneManager.LoadScene("MainMenuSwipeSports");
    }

    public void BackToMenu()
    {
        mainMenuConfirmation.SetActive(false);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenuSwipeSports");
    }

    public void Pausing()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            endCanvas.enabled = true;
            mainCanvas.enabled = false;
        }
        
    }

    public void UnPausing()
    {
        if (Time.timeScale == 0)
        {
            mainCanvas.enabled = true;
            endCanvas.enabled = false;
            
            Time.timeScale = 1;
        }
    }
}
