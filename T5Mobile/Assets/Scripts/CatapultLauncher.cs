using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatapultLauncher : MonoBehaviour {

    private Animator myAnimator;

    public GameObject Player;

    public GameObject theBall;

    public float launchTime;
    public float timeToLaunch;

    public float childTime;

    public GameObject releaseVolume;

    // Use this for initialization
    void Start ()
    {
        myAnimator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myAnimator.SetTrigger("Launch");
            
        }


        if (Input.GetKeyDown(KeyCode.M))
        {
            Player.transform.parent = null;

        }

        if (RelaseBall.releaseBall == true)
        {
            releaseVolume.SetActive(false);

            RelaseBall.releaseBall = false;
        }

    }

    private void OnTriggerStay2D(Collider2D Player)
    {
        Debug.Log("InCatapult");

        
        if (launchTime <= timeToLaunch)
        {
            launchTime += Time.deltaTime;

            
        }

        if (launchTime >= timeToLaunch)
        {
            Player.transform.parent = transform;

            myAnimator.SetTrigger("Launch");

            if (childTime <= 1)
            {

                 childTime += Time.deltaTime;

            }

            //if (childTime >= 0.25f)
            //{
            //    Player.transform.parent = null;

            //    childTime = 0;

            //    Debug.Log("WORK!!!!!!!!!!!!!");

            //}

            
            launchTime = 0;
        }

        if (childTime >= 0.0168f)
        {
            Player.transform.parent = null;

            childTime = 0;

            //launchTime = 0;

            Debug.Log("WORK!!!!!!!!!!!!!");

        }

        releaseVolume.SetActive(true);


    }
}
