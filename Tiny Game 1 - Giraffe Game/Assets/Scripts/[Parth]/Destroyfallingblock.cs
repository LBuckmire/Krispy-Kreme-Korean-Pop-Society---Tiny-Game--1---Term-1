using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyfallingblock : MonoBehaviour
{
    #region Destroy Object
    //public AudioClip CollisAudio; // This is where you add your audio clip (remove if wrong)
    //private AudioSource audioSource;

    void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / 20f; // This checks the gravity of the objects which have rigidbody since the start of the level

        //audioSource = GetComponent<AudioSource>();
        //audioSource.playOnAwake = false;
        //audioSource.clip = CollisAudio;
        //GetComponent<AudioSource>().playOnAwake = false; // Doesn't play on start (delete if wrong)
        //GetComponent<AudioSource>().clip = CollisAudio; // Selects an audioclip to play (delete if wrong)
    }


    // Update is called once per frame
    void Update ()
    {
		if (transform.position.y < -6f) // this if statement means that if any objects falls below -6 on the scale then the object will be destroyed
        {
            Destroy(gameObject);
        }
	}

    // Activates audio on collision (delete if wrong)


   /* void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            audioSource.clip = CollisAudio;
            audioSource.Play();
            //GetComponent<AudioSource>().Play();
        }   
    }*/
    #endregion
}
