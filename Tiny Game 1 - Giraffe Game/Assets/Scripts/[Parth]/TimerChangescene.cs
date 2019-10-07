using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerChangescene : MonoBehaviour {

    public float StartTimer; // This gives the player the options to choose what time the timer should start with

    private Text theText; // This allows the user to edit the text in the user interface of the text section

    public string loadscene1;

    #region Timer
    // Use this for initialization
    void Start () {

        theText = GetComponent<Text>(); // This tells the system to search for a component called text
    }
	
	// Update is called once per frame
	void Update () {

        StartTimer -= Time.deltaTime; // This starts the timer
        theText.text = "" + Mathf.Round(StartTimer); // this makes the number to be a whole number rather than decimals

        if (StartTimer <= 0) // this if statement means that if the timer hits 0 load the following scene 
        {
            SceneManager.LoadScene(loadscene1);

        }

	}
    #endregion

}
