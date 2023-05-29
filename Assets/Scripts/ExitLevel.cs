using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitLevel : MonoBehaviour
{

    AchievetmentSession achievetment;

    void Start()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
        achievetment = FindObjectOfType<AchievetmentSession>();
        Debug.Log(currentScene);
        Debug.Log(achievetment.stars);
    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        if (currentScene == 13 && achievetment.stars < 2)
        {
            achievetment.IncreaseStar();
        }
        if (currentScene == 16 && achievetment.stars < 2)
        {
            achievetment.IncreaseStar();
        }
        LoadNextScene();
        gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
    }
    private void LoadNextScene()
    {
        StartCoroutine(achievetment.LoadLevel());
    }
    private void LoadStageLevel()
    {

    }
}
