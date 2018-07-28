using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SoccerWinLevel : MonoBehaviour {

    public static int LeagueScore;                                      //Static ints
    public static int GoalsFor;
    public static int GoalsAgainst;

    public int levelNumber;                                             //Par and current level
    public int parNumber;

    public Canvas soccerFinishCanvas;

    public TextMeshProUGUI levelNo;                                     //Text for home, away, and level
    public TextMeshProUGUI strokeNo;
    public TextMeshProUGUI parNo;

    public Animator endLevel;                                           //animation for ending the level

    private int enemyGoals;                                             //ints for home and away goals
    private int yourGoals;

    public TextMeshProUGUI goalsAgainst;                                //ending text 
    public TextMeshProUGUI goalsFor;
    public TextMeshProUGUI leagueScore;

    public string nextLevel;                                            //next level string

    private void Start()
    {
        enemyGoals = 0;                                                 //refreshes enemyGoals and yourGoals to 0, just to be safe
        yourGoals = 0;
    }

    private void OnTriggerEnter2D(Collider2D Ball)
    {
        if (Ball.tag == "Player")
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = false;       //turn off collider
            SoccerManager.yourGoals++;                                      //adds 1 goal to your score and starts 2 functions
            StartCoroutine(FinishLevel());
            AddToTable();
        }
    }

    IEnumerator FinishLevel()
    {
        yield return new WaitForSeconds(2);                             //wait 2 seconds to let music play
        EndGame();
    }

    public void EndGame()
    {                                                       
        levelNo.text = "Completed Game " + levelNumber;                 //initialise text on the right to show info about the round
        strokeNo.text = "in " + SoccerManager.enemyGoals + " hits.";
        parNo.text = "The final score was: " + (parNumber + SoccerManager.yourGoals) + " - " + SoccerManager.enemyGoals;

        StartCoroutine(PlayEndAnimation());
    }

    IEnumerator PlayEndAnimation()
    {
        endLevel.SetTrigger("end");                                     //play animation then turns on the end screen plan
        yield return new WaitForSeconds(1.5f);
        soccerFinishCanvas.enabled = true;
    }

    public void AddToTable()
    {
        //if (levelNumber == 1)
        //{
        //    EnemyGoals1 = SoccerManager.enemyGoals;
        //    YourGoals1 = parNumber + SoccerManager.yourGoals;
            
        //    GoalsFor += YourGoals1;
        //    GoalsAgainst += SoccerManager.enemyGoals;

        //    goalsFor1.text = "" + YourGoals1;
        //    goalsAgainst1.text = "" + EnemyGoals1;
            
        //    if (YourGoals1 > EnemyGoals1)
        //    {
        //        LeagueScore += 3;
                
        //    }
        //    else if (YourGoals1 == EnemyGoals1)
        //    {
        //        LeagueScore += 1;
        //    }
        //    else if (YourGoals1 < EnemyGoals1)
        //    {
        //        LeagueScore += 0;
        //    }

        //}

        enemyGoals = SoccerManager.enemyGoals;                      //initialise enemyGoals and yourGoals
        yourGoals = parNumber + SoccerManager.yourGoals;

        PlayerPrefs.GetInt("GoalsFor", GoalsFor);                   //add goals for and against to scoreboard
        PlayerPrefs.GetInt("GoalsAgainst", GoalsAgainst);
        GoalsFor += yourGoals;
        GoalsAgainst += enemyGoals;
        PlayerPrefs.SetInt("GoalsFor", GoalsFor);
        PlayerPrefs.SetInt("GoalsAgainst", GoalsAgainst);


        goalsFor.text = "" + GoalsFor;                             //initialise text on the leaderboard to show goals for, against and league score
        goalsAgainst.text = "" + GoalsAgainst;
        leagueScore.text = "" + LeagueScore;

        if (yourGoals > enemyGoals)                                 //checks to see if you won, drew or lost and gives points respectivley for it
        {
            LeagueScore += 3;
            leagueScore.text = "" + LeagueScore;
        }
        else if (yourGoals == enemyGoals)
        {
            LeagueScore += 1;
            leagueScore.text = "" + LeagueScore;
        }
        else if (yourGoals < enemyGoals)
        {
            LeagueScore += 0;
            leagueScore.text = "" + LeagueScore;
        }
    }

    public void Continue()                                          //load next level
    {
        SceneManager.LoadScene(nextLevel);
    }
}
