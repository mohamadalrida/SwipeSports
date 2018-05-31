using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Text scoreText;
    public Text scoreText2;
    public int scoring;
    public GameObject scorer;
    public GameObject timerGO;
    public GameObject timerGO2;
    public float time;
    public Text timer;
    public Text timer2;
    

    // Use this for initialization
    void Start()
    {
       // scoring = ScoreManager.score;
        scoreText.enabled = true;
        scoreText2.enabled = true;
        timer.enabled = true;
        timer2.enabled = true;
        time = 5;
    }

    // Update is called once per frame
    void Update()
    {
        timer.text = "Time Left: " + time.ToString("f1");
        timer2.text = "Time Left: " + time.ToString("f1");
        time -= Time.deltaTime;
        
        if(time <= 0)
        {
            timerGO.SetActive(false);
            timerGO2.SetActive(false);
            ScoreManager.score = scoring;
            scorer.GetComponent<Score>().enabled = false;
            
        }

        scoreText.text = "Score: " + scoring;
        scoreText2.text = "Score: " + scoring;

        if (Input.GetMouseButtonDown(0))
        {
            scoring++;
        }
    }

    public void ResetPls()
    {
        PlayerPrefs.SetInt("highscore", 0);
    }
    
}