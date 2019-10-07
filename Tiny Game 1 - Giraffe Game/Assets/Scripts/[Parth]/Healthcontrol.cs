using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Healthcontrol : MonoBehaviour
{
    public GameObject Lives1, Lives2, Lives3, gameover;
    public static int health;
    public string newlevel;

    void Start()
    {
        health = 3;
        Lives1.gameObject.SetActive(true);
        Lives2.gameObject.SetActive(true);
        Lives3.gameObject.SetActive(true);
    }

    private void Update()
    {
        if (health > 3)
            health = 3;

        switch (health)
        {
            case 3:
                Lives1.gameObject.SetActive(true);
                Lives2.gameObject.SetActive(true);
                Lives3.gameObject.SetActive(true);
                break;

            case 2:
                Lives1.gameObject.SetActive(true);
                Lives2.gameObject.SetActive(true);
                Lives3.gameObject.SetActive(false);
                break;

            case 1:
                Lives1.gameObject.SetActive(true);
                Lives2.gameObject.SetActive(false);
                Lives3.gameObject.SetActive(false);
                break;

            case 0:
                Lives1.gameObject.SetActive(false);
                Lives2.gameObject.SetActive(false);
                Lives3.gameObject.SetActive(false);
                //Time.timeScale = 0;
                break;

        }

        if (health <= 0)// this code shows that when the lives are gone the game will end.
        {
            SceneManager.LoadScene(newlevel);
        }
    }

}
