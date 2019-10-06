using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyfallingblock : MonoBehaviour
{
    #region Destroy Object
    void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / 20f; // This checks the gravity of the objects which have rigidbody since the start of the level
    }


    // Update is called once per frame
    void Update ()
    {
		if (transform.position.y < -6f) // this if statement means that if any objects falls below -6 on the scale then the object will be destroyed
        {
            Destroy(gameObject);
        }
	}
    #endregion
}
