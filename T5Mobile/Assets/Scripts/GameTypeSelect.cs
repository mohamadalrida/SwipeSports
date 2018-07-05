using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameTypeSelect : MonoBehaviour {

    public string GolfLevels;
    public string BasketBallLevels;
    public string SoccerLevels;

    public Animator transitionAnim;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void GolfLevel()
    {
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(GolfLevels);
    }

    public void BasketBallLevel()
    {
        SceneManager.LoadScene(BasketBallLevels);
    }

    public void Soccer()
    {
        SceneManager.LoadScene(SoccerLevels);
    }

}
