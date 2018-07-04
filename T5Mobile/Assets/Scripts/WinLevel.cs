using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class WinLevel : MonoBehaviour
{

    public static int Strokes1;
    public static int Strokes2;
    public static int Strokes3;
    public static int Strokes4;
    public static int Strokes5;
    public static int Strokes6;
    public static int Strokes7;
    public static int Strokes8;
    public static int Strokes9;

    public static string Level1;
    public static string Level2;
    public static string Level3;
    public static string Level4;
    public static string Level5;
    public static string Level6;
    public static string Level7;
    public static string Level8;
    public static string Level9;

    public  TextMeshProUGUI Levels1;
    public  TextMeshProUGUI Levels2;
    public  TextMeshProUGUI Levels3;
    public  TextMeshProUGUI Levels4;
    public  TextMeshProUGUI Levels5;
    public  TextMeshProUGUI Levels6;
    public  TextMeshProUGUI Levels7;
    public  TextMeshProUGUI Levels8;
    public  TextMeshProUGUI Levels9;

    public GameObject Ball;
    public GameObject winTitle;

    public string nextLevel;

    //Public customisable ints of the level and par
    public int levelNumber;
    public int parNumber;

    public Canvas endGameCanvas;

    //Text that the numbers are set to
    public TextMeshProUGUI levelNo;
    public TextMeshProUGUI strokeNo;
    public TextMeshProUGUI parNo;


    private void OnTriggerEnter2D(Collider2D Ball)
    {
        EndGame();
        AddToTable();
    }

    public void EndGame()
    {
        endGameCanvas.enabled = true;

        levelNo.text = "Completed Hole " + levelNumber;
        strokeNo.text = "in " + StrokeManager.strokesNumber + " strokes.";
        parNo.text = "Par: " + parNumber;
    }

    public void AddToTable()
    {
        if (levelNumber == 1)
        {
            Strokes1 = StrokeManager.strokesNumber;
            Level1 = "" + Strokes1;
            Levels1.text = Level1;
        }

        if (levelNumber == 2)
        {
            Strokes2 = StrokeManager.strokesNumber;
        }

        if (levelNumber == 3)
        {
            Strokes3 = StrokeManager.strokesNumber;
        }

        if (levelNumber == 4)
        {
            Strokes4 = StrokeManager.strokesNumber;
        }

        if (levelNumber == 5)
        {
            Strokes5 = StrokeManager.strokesNumber;
        }

        if (levelNumber == 6)
        {
            Strokes6 = StrokeManager.strokesNumber;
        }

        if (levelNumber == 7)
        {
            Strokes7 = StrokeManager.strokesNumber;
        }

        if (levelNumber == 8)
        {
            Strokes8 = StrokeManager.strokesNumber;
        }

        if (levelNumber == 9)
        {
            Strokes9 = StrokeManager.strokesNumber;
        }

    }

    //Continues to the next level
    public void Continue()
    {
        endGameCanvas.enabled = true;
        SceneManager.LoadScene(nextLevel);
    }
}



