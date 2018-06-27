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
        Application.LoadLevel("GameTypeSelect");
    }

    public void Quit()
    {
        
    }

    public void LoadStore()
    {
        Application.LoadLevel("Shop");
    }

    public void Settings()
    {
        Application.LoadLevel("Settings");
    }

    public void Character()
    {
        Application.LoadLevel("Character");
    }
}
