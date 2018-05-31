using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Countdown : MonoBehaviour {

    public Text countdown;
    public Text countdown2;
    public GameObject canvas;
    public float time;
    public GameObject startButton;


    // Use this for initialization
    void Start () {

        startButton.SetActive(false);
        countdown.enabled = true;
        countdown2.enabled = true;
        time = 3;

	}
	
	// Update is called once per frame
	void Update () {

        countdown.text = time.ToString("f1");
        countdown2.text = time.ToString("f1");

        time -= Time.deltaTime;

        if(time <= 0)
        {

            countdown.text = "GO!";
            countdown2.text = "GO!";
            countdown.enabled = false;
            countdown2.enabled = false;
            canvas.GetComponent<Score>().enabled = true;
            canvas.GetComponent<Countdown>().enabled = false;
        }
    }
}
