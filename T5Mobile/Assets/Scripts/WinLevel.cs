using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLevel : MonoBehaviour {

    public GameObject Ball;
    public GameObject winTitle;

    public string nextLevel;

    
    private void OnTriggerEnter2D(Collider2D Ball)
    {
        //winTitle.SetActive(true);

        SceneManager.LoadScene(nextLevel);
    }

    // Update is called once per frame
    void Update ()
    {
		
	}
}
