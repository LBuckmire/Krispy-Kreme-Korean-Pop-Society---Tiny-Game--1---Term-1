using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningBlock : MonoBehaviour {

    public Transform[] spawning; // this allows the user to have many strings of objects. this also means the player can decide how many objects they want the game to spawn 

    public GameObject FallingblockPrefab; // this is a prefab for the objects that the is going to fall down. 

    public float delayinspawn = 1f; // this shows that there is a delay in between each spawn of the objects

    private float timeintospawn = 2f; // this shows the delay of the object at the start

    #region Delay in each Spawn
    void Update() // This if statement shows the calculation between delayed spawn and the time in spawn. the two variable add a time to calculate the next spawn in time
    {
        if (Time.time >= timeintospawn)
        {
            SpawningShapes();
            timeintospawn = Time.time + delayinspawn; 
        }
    }
    #endregion

    #region Random Spawning Shapes
    void SpawningShapes () // this section shows how the shapes are going to spawn. 
    {
        int randomnumber = Random.Range(0, spawning.Length); // this asks unity to randomly choose a object to not spawn

        for (int i = 0; i < spawning.Length; i++)
        {
            if (randomnumber != i)
            {
                Instantiate(FallingblockPrefab, spawning[i].position, Quaternion.identity);
            }
        }
    }
    #endregion
}