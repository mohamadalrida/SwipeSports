using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public static int score;
    public static int highscore;

    Text highestscore;
    public Text highestscore2;

	// Use this for initialization
	void Start ()
    {
        highestscore = GetComponent<Text>();

        score = 0;

        highscore = PlayerPrefs.GetInt("highscore", highscore);
        highestscore.text = "Highscore: " + highscore.ToString();
        highestscore2.text = "Highscore: " + highscore.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        if (score > highscore)
        {
            highscore = score;
            highestscore.text = "Highscore: " + score;
            highestscore2.text = "Highscore: " + score;

            PlayerPrefs.SetInt("highscore", highscore);
        }
    }

    public static void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
    }

    public void ResetPls()
    {
        PlayerPrefs.SetInt("highscore", 0);
    }
    
    public static void ResetScore()
    {
        score = 0;
    }
}
