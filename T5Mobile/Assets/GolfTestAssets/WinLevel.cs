using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLevel : MonoBehaviour {

    public GameObject Ball;
    public GameObject winTitle;

    
    private void OnTriggerEnter2D(Collider2D Ball)
    {
        //winTitle.SetActive(true);

        SceneManager.LoadScene("golftesting");
    }

    // Update is called once per frame
    void Update ()
    {
		
	}
}
