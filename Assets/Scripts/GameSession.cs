using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{
    public int target = 2;
    [SerializeField] GameObject exit;
    [SerializeField] Slider progressBar;



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ProcessNextLevel();

    }
    public void ProcessNextLevel()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        if (target == 0)
        {
            exit.SetActive(true);
            DestroyNonTarget();
            DestroyCanvas();
            switch (currentScene)
            {
                case 0:
                    progressBar.value = 0;
                    break;
                case 3:
                    progressBar.value = 0;
                    break;
                case 4:
                    progressBar.value = 1;
                    break;
                case 5:
                    progressBar.value = 2;
                    break;
                case 6:
                    progressBar.value = 3;
                    break;
                case 7:
                    progressBar.value = 1;
                    break;
                case 8:
                    progressBar.value = 2;
                    break;
                case 9:
                    progressBar.value = 3;
                    break;
                case 10:
                    progressBar.value = 4;
                    break;
                case 11:
                    progressBar.value = 5;
                    break;
                case 12:
                    progressBar.value = 6;
                    break;
                case 13:
                    progressBar.value = 7;
                    break;
                case 14:
                    progressBar.value = 8;
                    break;
                case 15:
                    progressBar.value = 9;
                    break;
                case 16:
                    progressBar.value = 10;
                    break;
                case 17:
                    progressBar.value = 11;
                    break;
                case 18:
                    progressBar.value = 1;
                    break;
            }
            // target = 4;
        }
    }
    public void reduceTarget()
    {
        target--;
    }

    void DestroyNonTarget()
    {
        GameObject[] notTarget = GameObject.FindGameObjectsWithTag("Not Target");
        foreach (GameObject i in notTarget)
        {
            GameObject.Destroy(i);
        }
    }

    void DestroyCanvas()
    {
        GameObject[] notTarget = GameObject.FindGameObjectsWithTag("Canvas");
        foreach (GameObject i in notTarget)
        {
            GameObject.Destroy(i);
        }
    }

}
