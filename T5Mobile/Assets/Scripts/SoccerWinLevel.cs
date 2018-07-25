using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SoccerWinLevel : MonoBehaviour {

    public static int EnemyGoals1;
    public static int EnemyGoals2;
    public static int EnemyGoals3;
    public static int EnemyGoals4;
    public static int EnemyGoals5;
    public static int EnemyGoals6;
    public static int EnemyGoals7;
    public static int EnemyGoals8;
    public static int EnemyGoals9;
   
    public static int LeagueScore;
    public static int GoalsFor;
    public static int GoalsAgainst;

    public static int YourGoals1;
    public static int YourGoals2;
    public static int YourGoals3;
    public static int YourGoals4;
    public static int YourGoals5;
    public static int YourGoals6;
    public static int YourGoals7;
    public static int YourGoals8;
    public static int YourGoals9;

    public TextMeshProUGUI goalsFor1;
    public TextMeshProUGUI goalsFor2;
    public TextMeshProUGUI goalsFor3;
    public TextMeshProUGUI goalsFor4;
    public TextMeshProUGUI goalsFor5;
    public TextMeshProUGUI goalsFor6;
    public TextMeshProUGUI goalsFor7;
    public TextMeshProUGUI goalsFor8;
    public TextMeshProUGUI goalsFor9;

    public TextMeshProUGUI goalsAgainst1;
    public TextMeshProUGUI goalsAgainst2;
    public TextMeshProUGUI goalsAgainst3;
    public TextMeshProUGUI goalsAgainst4;
    public TextMeshProUGUI goalsAgainst5;
    public TextMeshProUGUI goalsAgainst6;
    public TextMeshProUGUI goalsAgainst7;
    public TextMeshProUGUI goalsAgainst8;
    public TextMeshProUGUI goalsAgainst9;

    public int levelNumber;
    public int parNumber;

    public Canvas soccerFinishCanvas;

    public TextMeshProUGUI levelNo;
    public TextMeshProUGUI strokeNo;
    public TextMeshProUGUI parNo;

    public Animator endLevel;

    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D Ball)
    {
        SoccerManager.yourGoals++;
        StartCoroutine(FinishLevel());
        AddToTable();
    }

    IEnumerator FinishLevel()
    {
        yield return new WaitForSeconds(2);
        EndGame();
    }

    public void EndGame()
    {
        levelNo.text = "Completed Game " + levelNumber;
        strokeNo.text = "in " + SoccerManager.enemyGoals + " hits.";
        parNo.text = "The final score was: " + SoccerManager.yourGoals + " - " + SoccerManager.enemyGoals;

        StartCoroutine(PlayEndAnimation());
    }

    IEnumerator PlayEndAnimation()
    {
        endLevel.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        soccerFinishCanvas.enabled = true;
    }

    public void AddToTable()
    {
        if (levelNumber == 1)
        {
            EnemyGoals1 = SoccerManager.enemyGoals;
            YourGoals1 = parNumber + SoccerManager.yourGoals;
            goalsFor1.text = "" + YourGoals1;

            if (YourGoals1 > EnemyGoals1)
            {
                LeagueScore += 3;
            }
            else if (YourGoals1 == EnemyGoals1)
            {
                LeagueScore += 1;
            }
            else if (YourGoals1 < EnemyGoals1)
            {
                LeagueScore += 0;
            }
        }
    }
}
