using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameTypeSelect : MonoBehaviour {

    public string GolfLevels;
    public string BasketBallLevels;
    public string SoccerLevels;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void GolfLevel()
    {
        Application.LoadLevel(GolfLevels);
    }

    public void BasketBallLevel()
    {
        Application.LoadLevel(BasketBallLevels);
    }

    public void Soccer()
    {
        Application.LoadLevel(SoccerLevels);
    }

}
