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
    
    public string nextLevel;

    //Public customisable ints of the level and par
    public int levelNumber;
    public int parNumber;

    public Canvas holeFinishCanvas;

    //Text that the numbers are set to
    public TextMeshProUGUI levelNo;
    public TextMeshProUGUI strokeNo;
    public TextMeshProUGUI parNo;

    public TextMeshProUGUI finalScore;

    // Audio
    public AudioClip clap;
    private AudioSource audioSource;

    //Animation
    public Animator endLevel;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();


        //Insantiate all the the scores
        Level1 = "" + Strokes1;
        Levels1.text = Level1;

        Level2 = "" + Strokes2;
        Levels2.text = Level2;

        Level3 = "" + Strokes3;
        Levels3.text = Level3;

        Level4 = "" + Strokes4;
        Levels4.text = Level4;

        Level5 = "" + Strokes5;
        Levels5.text = Level5;

        Level6 = "" + Strokes6;
        Levels6.text = Level6;

        Level7 = "" + Strokes7;
        Levels7.text = Level7;

        Level8 = "" + Strokes8;
        Levels8.text = Level8;

        Level9 = "" + Strokes9;
        Levels9.text = Level9;

        finalScore.text = "You finished 9 holes in " + (Strokes1 + Strokes2 + Strokes3 + Strokes4 + Strokes5 + Strokes6 + Strokes7 + Strokes8 + Strokes9) + " strokes." + "\n" + "\n" + " The total par was 28.";
        
    }

    private void OnTriggerEnter2D(Collider2D Ball)
    {
        audioSource.Play();
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
        levelNo.text = "Completed Hole " + levelNumber;
        strokeNo.text = "in " + StrokeManager.strokesNumber + " strokes.";
        parNo.text = "Par: " + parNumber;

        StartCoroutine(PlayEndAnimation());
    }

    IEnumerator PlayEndAnimation()
    {
        endLevel.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        holeFinishCanvas.enabled = true;
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
            Level2 = "" + Strokes2;
            Levels2.text = Level2;
        }

        if (levelNumber == 3)
        {
            Strokes3 = StrokeManager.strokesNumber;
            Level3 = "" + Strokes3;
            Levels3.text = Level3;
        }

        if (levelNumber == 4)
        {
            Strokes4 = StrokeManager.strokesNumber;
            Level4 = "" + Strokes4;
            Levels4.text = Level4;
        }

        if (levelNumber == 5)
        {
            Strokes5 = StrokeManager.strokesNumber;
            Level5 = "" + Strokes5;
            Levels5.text = Level5;
        }

        if (levelNumber == 6)
        {
            Strokes6 = StrokeManager.strokesNumber;
            Level6 = "" + Strokes6;
            Levels6.text = Level6;
        }

        if (levelNumber == 7)
        {
            Strokes7 = StrokeManager.strokesNumber;
            Level7 = "" + Strokes7;
            Levels7.text = Level7;
        }

        if (levelNumber == 8)
        {
            Strokes8 = StrokeManager.strokesNumber;
            Level8 = "" + Strokes8;
            Levels8.text = Level8;
        }

        if (levelNumber == 9)
        {
            Strokes9 = StrokeManager.strokesNumber;
            Level9 = "" + Strokes9;
            Levels9.text = Level9;
        }
        
        // Play Audio of Clapping and winning

        //SceneManager.LoadScene(nextLevel);
    }

    //Continues to the Main Menu level
    public void Continue()
    {
        holeFinishCanvas.enabled = false;
        SceneManager.LoadScene(nextLevel);
    }

    
}



