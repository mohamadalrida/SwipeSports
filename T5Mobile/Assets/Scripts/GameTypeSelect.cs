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

        transitionAnim.SetTrigger("end");
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(GolfLevels);
    }

    public void BasketBallLevel()
    {
        SceneManager.LoadScene(BasketBallLevels);
    }

    public void Soccer()
    {
        StartCoroutine(LoadSScene());

    }

    IEnumerator LoadSScene()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(SoccerLevels);
    }

}
