using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float tT = Time.time - startTime;

        string minutes = ((int)tT / 60).ToString();
        string seconds = ((int)tT % 60f).ToString();
       

        timerText.text = minutes + ":" + seconds;
    }
}
