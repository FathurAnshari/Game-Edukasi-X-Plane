using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitLevel : MonoBehaviour
{


    void Start()
    {

    }


    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        LoadNextScene();
    }
    private void LoadNextScene()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 3;
        }
        if (nextSceneIndex == 14)
        {
            nextSceneIndex = 3;
        }

        SceneManager.LoadScene(nextSceneIndex);

    }
    private void LoadStageLevel()
    {

    }
}
