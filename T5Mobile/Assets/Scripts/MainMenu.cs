using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void Play()
    {
        SceneManager.LoadScene("GameTypeSelect");
    }

    public void Quit()
    {
        
    }

    public void LoadStore()
    {
        SceneManager.LoadScene("Shop");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void Character()
    {
        SceneManager.LoadScene("Character");
    }
}
