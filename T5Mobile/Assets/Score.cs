using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Text scoreText;
    public int score;
    public GameObject scorer;
    public GameObject timerGO;
    public GameObject startButton;
    public float time;
    public Text timer;
    

    // Use this for initialization
    void Start()
    {
        startButton.SetActive(false);
        scoreText.enabled = true;
        timerGO.SetActive(true);
        time = 5;
    }

    // Update is called once per frame
    void Update()
    {
        timer.text = "Time Left: " + time.ToString("f1");
        time -= Time.deltaTime;
        
        if(time <= 0)
        {
            
            timerGO.SetActive(false);
            scorer.GetComponent<Score>().enabled = false;

        }

        scoreText.text = "Score: " + score;

        if (Input.GetMouseButtonDown(0))
        {
            score++;
        }
    }
    
}