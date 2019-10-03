using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager_TG : MonoBehaviour
{
    public string SceneName;

    public void OnMouseClick()
    {
        SceneManager.LoadScene(SceneName);
    }


}
