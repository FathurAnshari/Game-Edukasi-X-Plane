using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class AchievetmentSession : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI starsText;
    [SerializeField] GameObject starCanvas;
    [SerializeField] GameObject keyPad;
    [SerializeField] Animator transitionAnim;
    [SerializeField] Button misi2;
    [SerializeField] Button misi3;
    [SerializeField] Button misi4;
    [SerializeField] Slider progressBar;
    [SerializeField] float progressBarValue;
    bool udahTamat = false;

    void Awake()
    {
        int numAchievementSession = FindObjectsOfType<AchievetmentSession>().Length;
        if (numAchievementSession > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    private void Start()
    {
        progressBarValue = progressBar.value;
        progressBar.maxValue = 3;
        progressBar.value = 0;
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        if (currentScene == 0)
        {
            starCanvas.gameObject.SetActive(false);
            keyPad.gameObject.SetActive(false);
        }


    }
    private void Update()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;

        switch (currentScene)
        {
            case 0:
                starCanvas.gameObject.SetActive(false);
                keyPad.gameObject.SetActive(false);
                progressBar.value = 0;
                break;
            case 3:
                starCanvas.gameObject.SetActive(false);
                keyPad.gameObject.SetActive(false);
                progressBar.value = 0;
                break;
            case 4:
                starCanvas.gameObject.SetActive(true);
                keyPad.gameObject.SetActive(true);
                progressBar.value = 1;
                break;
            case 5:
                progressBar.value = 2;
                break;
            case 6:
                progressBar.value = 3;
                break;
            case 7:
                starCanvas.gameObject.SetActive(true);
                keyPad.gameObject.SetActive(true);
                progressBar.value = 1;
                progressBar.maxValue = 11;
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
                starCanvas.gameObject.SetActive(true);
                keyPad.gameObject.SetActive(true);
                progressBar.value = 1;
                progressBar.maxValue = 1;

                break;
        }

        // if (currentScene == 0)
        // {
        //     starCanvas.gameObject.SetActive(false);
        //     progressBar.value = 0;
        // }
        // if (currentScene == 3)
        // {
        //     starCanvas.gameObject.SetActive(false);
        //     progressBar.value = 0;
        // }
        // if (currentScene == 4)
        // {
        //     starCanvas.gameObject.SetActive(true);
        //     progressBar.value = 1;
        // }
        // if (currentScene == 5)
        // {

        //     progressBar.value = 2;

        // }
        // if (currentScene == 6)
        // {
        //     progressBar.value = 3;

        // }
        // if (currentScene == 7)
        // {
        //     starCanvas.gameObject.SetActive(true);
        //     progressBar.value = 1;
        //     progressBar.maxValue = 6;
        // }

    }
    // public void ProcessNextMission()
    // {
    //     IncreaseStar();
    // }

    public void IncreaseValue()
    {
        progressBar.value++;

    }


    public IEnumerator LoadLevel()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            // PlayerPrefs.DeleteKey("levelAt");
            PlayerPrefs.SetInt("levelAt", 4);
            misi2.interactable = true;
            misi3.interactable = true;
            udahTamat = true;
            nextSceneIndex = 0;
        }
        else
        {
            if (nextSceneIndex == 7 && !udahTamat)
            {
                PlayerPrefs.SetInt("levelAt", 3);
                misi2.interactable = true;
                misi3.interactable = false;
                nextSceneIndex = 3;
            }
            if (nextSceneIndex == 7 && udahTamat)
            {
                nextSceneIndex = 3;
            }


            if (nextSceneIndex == 18 && !udahTamat)
            {

                misi2.interactable = true;
                misi3.interactable = true;

                nextSceneIndex = 3;
            }
            if (nextSceneIndex == 18 && udahTamat)
            {
                nextSceneIndex = 3;
            }


        }
        transitionAnim.SetTrigger("End");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(nextSceneIndex);
        transitionAnim.SetTrigger("Start");

    }
}
