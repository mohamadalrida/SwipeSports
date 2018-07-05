using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class EndGamePanel : MonoBehaviour {

    //-----------------------------------------------------------------------------------------------------//
    //------------------------------------- VARIABLES -----------------------------------------------------//
    //-----------------------------------------------------------------------------------------------------//

    
    
    

    //Canvas' that get turned on and off
    public Canvas mainCanvas;
    public Canvas optionsCanvas;

    //Turns on the panels for the menu
    public GameObject optionsMenu;
    public GameObject mainMenuConfirmation;
    

    //-----------------------------------------------------------------------------------------------------//
    //------------------------------------- CODE ----------------------------------------------------------//
    //-----------------------------------------------------------------------------------------------------//



    //Resets the time scale and canvas to be default when the level starts
    void Start () {

        Time.timeScale = 1;
        mainCanvas.enabled = true;
        optionsCanvas.enabled = false;
	}



    



    //Shows the options menu
    public void Options()
    {
        optionsMenu.SetActive(true);
    }



    //Shows a pop up Yes/No menu to if you want to quit
    public void MenuConfirmation()
    {
        mainMenuConfirmation.SetActive(true);
    }



    //Return to previous
    public void BackToMenu()
    {
        mainMenuConfirmation.SetActive(false);
        optionsMenu.SetActive(false);
    }



    //Return to main menu
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenuSwipeSports");
    }



    //Pauses the game
    public void Pausing()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            optionsCanvas.enabled = true;
            mainCanvas.enabled = false;
        }
    }



    //Unpauses the game
    public void UnPausing()
    {
        if (Time.timeScale == 0)
        {
            mainCanvas.enabled = true;
            optionsCanvas.enabled = false;
            
            Time.timeScale = 1;
        }
    }



    //Displays end game canvas
    
}
