using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashScreen : MonoBehaviour {

    public GameObject panel;
    static bool notFirst = false;

	// Use this for initialization
	void Start () {

        if(notFirst == true)
        {
            Destroy(panel);
        }
        else
        {
            StartCoroutine(KillMe());
        }
        
	}

    IEnumerator KillMe()
    {
        yield return new WaitForSeconds(5.25f);
        Destroy(panel);
        notFirst = true;
    }
	
	
}
